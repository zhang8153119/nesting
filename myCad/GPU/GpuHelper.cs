using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using Cloo;
using System .Diagnostics;
using System .Collections .ObjectModel;
using System .Runtime .InteropServices;
using System .Drawing;
using System .ComponentModel;

namespace GPU
{
      class GpuHelper<TFP> : GPU .IGpuHelper where TFP : struct
      {
            private ComputeContext context;
            private ComputeCommandQueue commands;
            ICollection<ComputeEventBase> events = new Collection<ComputeEventBase>();

            FPType fpType;

            public GpuHelper(ComputeContext context, FPType fptype)
            {
                  this .context = context;
                  commands = new ComputeCommandQueue(context, context .Devices[0], ComputeCommandQueueFlags .None);
                  this .fpType = fptype;
            }
            #region hello
            public void GetHello(float num, ref float result)
            {
                  TFP t = Hello(num);
                  result = Convert .ToSingle(t);
            }
            public TFP Hello(float num)
            {
                  ComputeBuffer<TFP> result = new ComputeBuffer<TFP>(context, ComputeMemoryFlags .WriteOnly, 1);
                  string source = Encoding .ASCII .GetString(myCad .Properties .Resources .nest);

                  if (fpType == FPType .FP64AMD)
                  {
                        source = "#define AMDFP64\n" + source;
                  }
                  else if (fpType == FPType .FP64)
                  {
                        source = "#define FP64\n" + source;
                  }
                  ComputeProgram program = new ComputeProgram(context, source);
                  try
                  {
                        program .Build(null, null, null, IntPtr .Zero);
                  }
                  catch (Exception)
                  {
                        var log = program .GetBuildLog(context .Devices[0]);
                        Debugger .Break();
                  }

                  ComputeKernel kernel = program .CreateKernel("hello");

                  TFP[] myresult = RunKernalTest(num, result, kernel);
                  return myresult[0];
            }
            private TFP[] RunKernalTest(float num, ComputeBuffer<TFP> result, ComputeKernel kernel)
            {
                  kernel .SetMemoryArgument(0, result);
                  kernel .SetValueArgument(1, num);

                  // BUG: ATI Stream v2.2 crash if event list not null.
                  commands .Execute(kernel, null, new long[] { 1, 1 }, null, events);
                  //commands.Execute(kernel, null, new long[] { count }, null, null);

                  TFP[] myresult = new TFP[1];

                  GCHandle arrCHandle = GCHandle .Alloc(myresult, GCHandleType .Pinned);

                  commands .Read(result, true, 0, 1, arrCHandle .AddrOfPinnedObject(), events);

                  arrCHandle .Free();
                  return myresult;
            }
            #endregion
            #region ArrayTest
            public int ArrayTest(int[,] a1, int[,] b)
            {
                  Point f;
                  int[,] a = new int[2, 2];
                  MyPoint[] plist = new MyPoint[100000];
                  MyPoint p1 = new MyPoint() { X = 1, Y = 1 };
                  MyPoint p2 = new MyPoint() { X = 2, Y = 2 };
                  plist[0] = p1;
                  plist[1] = p2;


                  IntPtr dataaddr_a = Marshal .UnsafeAddrOfPinnedArrayElement(plist, 0);
                  ComputeBuffer<MyPoint> abuffer = new ComputeBuffer<MyPoint>(context, ComputeMemoryFlags .ReadOnly | ComputeMemoryFlags .CopyHostPointer, plist);

                  string source = Encoding .ASCII .GetString(myCad .Properties .Resources .nest);
                  ComputeProgram program = new ComputeProgram(context, source);
                  try
                  {
                        program .Build(null, null, null, IntPtr .Zero);
                  }
                  catch (Exception)
                  {
                        var log = program .GetBuildLog(context .Devices[0]);
                        Debugger .Break();
                  }

                  ComputeKernel kernel = program .CreateKernel("Sum");

                  ComputeBuffer<MyPoint> outdata = new ComputeBuffer<MyPoint>(context, ComputeMemoryFlags .ReadWrite, plist .Length);
                  kernel .SetMemoryArgument(0, abuffer);
                  kernel .SetMemoryArgument(1, outdata);

                  commands .Execute(kernel, null, new long[] { 2 }, null, events);

                  MyPoint[] myresult = new MyPoint[2];

                  GCHandle arrCHandle = GCHandle .Alloc(myresult, GCHandleType .Pinned);
                  commands .Read(outdata, true, 0, 2, arrCHandle .AddrOfPinnedObject(), events);
                  MyPoint[] test = myresult;
                  arrCHandle .Free();

                  return 0;
            }

            #endregion

            #region GetGridValue
            public int[,] GetGridValue(List<PointF> pointlist, float W, float H, float T)
            {
                  int WI = Convert .ToInt32(Math .Ceiling(W / T));
                  int HI = Convert .ToInt32(Math .Ceiling(H / T));
                  int pc = pointlist .Count;
                  MyPoint[] plist = new MyPoint[pc];
                  for (int i = 0; i < pointlist .Count; i++)
                  {
                        plist[i] .X = pointlist[i] .X;
                        plist[i] .Y = pointlist[i] .Y;
                  }
                  ComputeBuffer<MyPoint> pbuffer = new ComputeBuffer<MyPoint>(context, ComputeMemoryFlags .ReadOnly | ComputeMemoryFlags .CopyHostPointer, plist);

                  string source = Encoding .ASCII .GetString(myCad .Properties .Resources .nest);
                  source = "#define PCOUNT " + pc .ToString() + "\n" + source;
                  //source = source .Replace("\r", "") .Replace("\t", "");
                  ComputeProgram program = new ComputeProgram(context, source);
                  try
                  {
                        program .Build(null, null, null, IntPtr .Zero);
                  }
                  catch (Exception)
                  {
                        var log = program .GetBuildLog(context .Devices[0]);
                        Debugger .Break();
                  }

                  ComputeKernel kernel = program .CreateKernel("GetGridValue");

                  ComputeBuffer<int> outdata = new ComputeBuffer<int>(context, ComputeMemoryFlags .WriteOnly, WI * HI);
                  kernel .SetMemoryArgument(0, pbuffer);
                  kernel .SetValueArgument(1, W);
                  kernel .SetValueArgument(2, H);
                  kernel .SetValueArgument(3, T);
                  kernel .SetValueArgument(4, WI);
                  kernel .SetValueArgument(5, HI);
                  kernel .SetMemoryArgument(6, outdata);

                  commands .Execute(kernel, null, new long[] { WI + HI }, null, events);

                  int[,] myresult = new int[WI, HI];
                  for (int i = 0; i < WI; i++)
                  {
                        for (int j = 0; j < HI; j++)
                        {
                              myresult[i, j] = 0;
                        }
                  }
                  GCHandle arrCHandle = GCHandle .Alloc(myresult, GCHandleType .Pinned);
                  commands .Read(outdata, true, 0, WI * HI, arrCHandle .AddrOfPinnedObject(), events);
                  
                  //
                  /*ComputeBuffer<MyPoint> testdata = new ComputeBuffer<MyPoint>(context, ComputeMemoryFlags .WriteOnly, WI * HI);
                  ComputeBuffer<MyPoint> parray = new ComputeBuffer<MyPoint>(context, ComputeMemoryFlags .WriteOnly, pc);
                  kernel .SetMemoryArgument(0, pbuffer);
                  kernel .SetValueArgument(1, W);
                  kernel .SetValueArgument(2, H);
                  kernel .SetValueArgument(3, T);
                  kernel .SetValueArgument(4, WI);
                  kernel .SetValueArgument(5, HI);
                  kernel .SetMemoryArgument(6, outdata);
                  kernel .SetMemoryArgument(7, testdata);
                  kernel .SetMemoryArgument(8, parray);

                  commands .Execute(kernel, null, new long[] { WI + HI }, null, events);

                  int[,] myresult = new int[WI, HI];
                  for (int i = 0; i < WI; i++)
                  {
                        for (int j = 0; j < HI; j++)
                        {
                              myresult[i, j] = 0;
                        }
                  }
                  MyPoint[,] test = new MyPoint[WI, HI];
                  for (int i = 0; i < WI; i++)
                  {
                        for (int j = 0; j < HI; j++)
                        {
                              test[i, j] .X = 0;
                              test[i, j] .Y = 0;
                        }
                  }
                  int[] thisresult = new int[WI * HI];
                  MyPoint[] test3 = new MyPoint[pc];

                  GCHandle arrCHandle = GCHandle .Alloc(thisresult, GCHandleType .Pinned);
                  commands .Read(outdata, true, 0, WI * HI, arrCHandle .AddrOfPinnedObject(), events);

                  GCHandle arrCHandle2 = GCHandle .Alloc(test, GCHandleType .Pinned);
                  commands .Read(testdata, true, 0, WI * HI, arrCHandle2 .AddrOfPinnedObject(), events);

                  GCHandle arrCHandle3 = GCHandle .Alloc(test3, GCHandleType .Pinned);
                  commands .Read(parray, true, 0, pc, arrCHandle3 .AddrOfPinnedObject(), events);*/
                  arrCHandle .Free();
                  kernel .Dispose();
                  program .Dispose();
                  pbuffer .Dispose();
                  outdata .Dispose();
                  return myresult;
            }
            #endregion
      }


      public struct MyPoint
      {
            public float X { get; set; }
            public float Y { get; set; }
      }
}

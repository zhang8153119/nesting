using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using Cloo;
using System .Diagnostics;
using System .Collections .ObjectModel;
using System .Runtime .InteropServices;

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
      }
}

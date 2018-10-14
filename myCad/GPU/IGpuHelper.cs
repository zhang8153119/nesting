using Cloo;
using myCad .Utility;
using System;
using System .Collections .Generic;
using System .Drawing;

namespace GPU
{
      interface IGpuHelper
      {
            void GetHello(float num, ref float str);

            GridLib GetGridValue(List<PointF> pointlist, float W, float H, float T, ComputeProgram gpuprogram);


            int[,] GetGridValue(List<PointF> pointlist, float W, float H, float T);

            int[] Insert(int[] numlist, int num, ComputeProgram program);
            ComputeProgram Build();
      }
}

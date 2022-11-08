using System.Collections.Generic;
using UnityEngine;

namespace Project.Helpers
{
    public static class NumberHelper
    {
        public static int GetValue(this float f)
            => f == 0 ? 0 : (int)(Mathf.Abs(f) / f);

        public static float Average(this float[] arr)
        {
            float sum = 0f;
            foreach(var item in arr)
                sum += item;
            return sum / arr.Length;
        }

        public static float Average(this List<float> list)
            => list.ToArray().Average();
    }
}
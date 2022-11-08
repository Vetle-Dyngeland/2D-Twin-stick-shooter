using UnityEngine;
using System.Collections.Generic;

namespace Project.Helpers
{
    public static class VectorHelper
    {
        public static Vector2 GetValue(this Vector2 v)
            => new(v.x.GetValue(), v.y.GetValue());

        public static Vector2 Average(this Vector2[] arr)
        {
            Vector2 sum = Vector2.zero;
            foreach(var vector in arr)
                sum += vector;
            return sum / arr.Length;
        }

        public static Vector2 Average(this List<Vector2> list)
            => list.ToArray().Average();
    }
}
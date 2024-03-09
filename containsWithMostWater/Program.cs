using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace containsWithMostWater
{
    public class Program
    {
        public static void Main(string[ ] args)
        {
            var res = MaxArea([]);
        }

        public static int MaxArea(int[] height) 
        {
            if(height.Length < 2)
            return 0;

            int area = 0;
            var i = 0; 
            var j = height.Length -1;
            while(i < j)
            {
                var t_area = Math.Min(height[i], height[j]) * (j-i);

                if(height[i] < height[j])
                    i++;
                else
                    j--;

                if(t_area > area)
                    area = t_area;
            }
            return area;
        }
    }
}
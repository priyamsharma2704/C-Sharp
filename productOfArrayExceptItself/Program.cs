using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace productOfArrayExceptItself
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int [] r = ProductExceptSelf(new int []{1,2,3,4});
        }

         public static int[] ProductExceptSelf(int[] nums) 
         {
            List<int> l = new List<int>();
            int [] lProd = new int [nums.Length];
            int [] rProd = new int [nums.Length];
            
            for(var i = 0 ; i < nums.Length; i++)
            {
                if(i == 0)
                {
                    lProd[i] = 1;
                }
                else
                {
                    lProd[i] = lProd[i-1] * nums[i-1];
                }
            }

            for(var i = nums.Length-1 ; i >= 0; i--)
            {
                if(i == nums.Length-1)
                {
                    rProd[i] = 1;
                }
                else
                {
                    rProd[i] = rProd[i+1] * nums[i+1];
                }
            }
            
            for(var i = 0 ; i < nums.Length; i++)
            {
                l.Add(lProd[i] *rProd[i]);
            }

            return l.ToArray();
        }
    }
}
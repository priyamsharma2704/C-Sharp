using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestTimeToSellStocks
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int res= 0;
            int[] nums = [];
            res = MaxProfit(nums);
        }

        public static int MaxProfit(int[] prices) 
        {
            int min = Int32.MaxValue;
            int max_profit = 0;
            for(var i = 0; i < prices.Length; i++)
            {
                if(prices[i] < min)
                    min = prices[i];
                
                var profit = prices[i] - min;
                if(profit > max_profit)
                    max_profit = profit;
            }
            return max_profit;
        }    
    }
}
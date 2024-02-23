using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bestTimeToSellStocks2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int res = 0;
            res = MaxProfit([]);
        }

        public static int MaxProfit(int[] prices) 
        {
            int profit = 0;
            for(var i = 1; i< prices.Length; i++)
            {
                if(prices[i] > prices[i-1])
                {
                    profit += prices[i] - prices[i-1];
                }
            }
            return profit;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace calcMax
{
    class Program
    {
        static void Main(string[] args)
        {
            // 商品数とキャンペーン日数の取得
            var line = System.Console.ReadLine().Trim().Split(' ');
            int goodsNum = int.Parse(line[0]);
            int day = int.Parse(line[1]);

            // 商品の価格
            int[] prices = new int[goodsNum];
            int count = 0;
            foreach (int p in prices)
            {
                prices[count] = int.Parse(System.Console.ReadLine().Trim());
                count++;
            }

            // 目標金額
            count = 0;
            int[] goalPrices = new int[day];
            foreach (int p in goalPrices)
            {
                goalPrices[count] = int.Parse(System.Console.ReadLine().Trim());
                count++;
            }

            foreach (int goal in goalPrices)
            {
                int max = SearchMax(goal, prices);

                Console.WriteLine(max.ToString());
            }
        }

        static int SearchMax(int goal, int[] prices)
        {
            int max = 0;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] >= goal)
                {
                    continue;
                }

                for (int k = i + 1; k < prices.Length; k++)
                {
                    if (prices[k] >= goal)
                    {
                        continue;
                    }

                    int p = prices[i] + prices[k];
                    if (p <= goal)
                    {
                        if (p == goal)
                        {
                            return p;
                        }
                        else if (p > max)
                        {
                            max = p;
                        }
                    }
                }
            }
            return max;
        }
    }
}

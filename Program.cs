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
            int[] price = new int[goodsNum];
            int count = 0;
            foreach (int p in price)
            {
                price[count] = int.Parse(System.Console.ReadLine().Trim());
                count++;
            }

            // 目標金額
            count = 0;
            int[] goalPrice = new int[day];
            foreach (int p in goalPrice)
            {
                goalPrice[count] = int.Parse(System.Console.ReadLine().Trim());
                count++;
            }

            count = 0;
            foreach (int goal in goalPrice)
            {
                int max = 0;
                bool bEnd = false;
                for (int i = 0; i < price.Length; i++)
                {
                    for (int k = i + 1; k < price.Length; k++)
                    {
                        int p = price[i] + price[k];
                        if (p <= goal)
                        {
                            if (p == goal)
                            {
                                bEnd = true;
                                max = p;
                                break;
                            }
                            else if (p > max)
                            {
                                max = p;
                            }
                        }
                    }

                    if (bEnd)
                        break;
                }

                Console.WriteLine(max.ToString());
            }
        }
    }
}

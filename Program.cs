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
            int goalValue = 0;
            foreach (int goal in goalPrice)
            {
                bool bEnd = false;
                foreach (int value in price)
                {
                    foreach (int value2 in price)
                    {
                        int thisPrice = value + value2;
                        if (thisPrice == goal)
                        {
                            goalValue = thisPrice;
                            bEnd = true;
                            break;
                        }

                        if (thisPrice <= goal)
                        {
                            if (thisPrice > goalValue)
                            {
                                goalValue = thisPrice;
                            }
                        }
                    }

                    if (bEnd)
                        break;
                }

                Console.WriteLine(goalValue.ToString());
            }
        }
    }
}

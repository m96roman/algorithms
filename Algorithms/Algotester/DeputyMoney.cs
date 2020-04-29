using System;
using System.Collections.Generic;
using System.Text;

namespace Algotester
{
    public class DeputyMoney
    {
        public void Run()
        {
            var input = Console.ReadLine();
            var money = int.Parse(input.Trim());

            var bills = new int[] { 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            var billsCount = 0;
            while(money > 0)
            {
                for (var i = 0; i < bills.Length; ++i){
                    if(money >= bills[i])
                    {
                        money -= bills[i];
                        billsCount += 1;
                        break;
                    }
                }
            }

            Console.WriteLine(billsCount);
        }
    }
}

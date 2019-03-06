using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            bool flag = true;
            Console.WriteLine("请输入一个正整数");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("它的所有质因子为：");
            for (int i = 2; i < num; i++)
            {
                flag = true;
                if (num % i == 0)//如果是因子
                {   
                    for (int j = 2; j < i; j++)//如果是质数，则flag为真
                    {
                        if (i % j == 0)
                        {
                            flag = false;
                            break;
                        }
                    }
                    if(flag)    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0;
            Console.WriteLine("请输入第一个数字");
            num1= double.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数字");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("两数的乘积为{0}",num1*num2);
            Console.ReadKey();
        }
    }
}

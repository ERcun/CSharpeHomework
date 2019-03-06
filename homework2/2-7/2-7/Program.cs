using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("请输入数组元素个数");
            count = int.Parse(Console.ReadLine());
            int[] numlist = new int[count];
            Console.WriteLine("请输入整数数组的成员，一个一行");
            for (int i = 0; i < count; i++)//初始化数组
            {
                numlist[i]= int.Parse(Console.ReadLine());
            }
            //输出部分，直接调用方法
            Console.WriteLine("最大值为：{0}",numlist.Max());
            Console.WriteLine("最小值为：{0}",numlist.Min());
            Console.WriteLine("平均值为：{0}", numlist.Average());
            Console.WriteLine("所有元素的和为：{0}", numlist.Sum());
            Console.ReadKey();
        }
    }
}

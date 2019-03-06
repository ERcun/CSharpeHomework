using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 100;//想要求的范围的上限，可以调节不限于100
            int[] numlist = new int[max-1];//存储2~max的数字
            for (int i = 0; i < max-1; i++)    numlist[i] = i + 2;//赋值
            for (int j = 2; j < max; j++)//j是因子
            {
                for(int n = 2; n * j < max+1; n++)  numlist[n*j-2] = 0;//n是倍数，n*j是要去掉的数字
            }
            //输出部分
            Console.WriteLine("2~{0}以内的素数有：",max);
            int count = 0;//10个换行显示
            foreach (int t in numlist)
            {
                if (t != 0)
                {
                    Console.Write(" " + t);
                    count++;
                }
                if (count == 10)
                {
                    Console.WriteLine("");
                    count = 0;
                }
            }
            Console.ReadKey();
        }
    }
}

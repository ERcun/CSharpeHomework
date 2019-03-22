using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Timers.Timer aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(TimeEvent);
            // 设置引发时间的时间间隔 此处设置为１秒
            aTimer.Interval = 1000;
            aTimer.Enabled = true;
            Console.ReadKey();
        }

        private static void TimeEvent(object source, ElapsedEventArgs e)
        {

            // 得到 hour minute second 如果等于某个值就开始执行某个程序
            DateTime date1 = e.SignalTime;
            int intHour = e.SignalTime.Hour;
            int intMinute = e.SignalTime.Minute;
            int intSecond = e.SignalTime.Second;
            Console.WriteLine("{0}：{1}：{2}", intHour, intMinute, intSecond);
            // 定制时间； 比如 在10：30 ：00 的时候执行某个函数
            int iHour = 9;
            int iMinute = 10;
            int iSecond = 00;
            // 设置多少秒的时候开始执行
            if (intSecond == iSecond)
            {
                Console.WriteLine("每秒钟的开始执行一次");
            }
            if (intMinute == iMinute && intSecond == iSecond)
            {
                Console.WriteLine("每个小时的３０分钟开始执行一次");
            }
            if (intHour == iHour && intMinute == iMinute && intSecond == iSecond)
            {
                Console.WriteLine("在每天9点10分开始执行");
            }
        }
    }
}

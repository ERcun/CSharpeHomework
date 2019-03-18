using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Factory_Pattern
{
    class Program
    {
        public abstract class MobilePhone//手机类
        {

            public abstract void print();
        }

        public class Iphone : MobilePhone//苹果手机类
        {

            public override void print()
            {
                Console.WriteLine("我是苹果品牌！");
            }
        }

        public class XiaoMI : MobilePhone//小米手机类
        {
            public override void print()
            {
                Console.WriteLine("我是小米手机");
            }
        }

        public class SmarTisan : MobilePhone//锤子手机类
        {
            public override void print()
            {
                Console.WriteLine("我是锤子手机！");
            }
        }

        public class MobielPhoneFactory//手机工厂类
        {
            public static MobilePhone CreateMobilePhone(string PhoneBrand)
            {
                MobilePhone mobilePhone = null;
                if (PhoneBrand.Equals("苹果"))
                {
                    mobilePhone = new Iphone();
                }
                else if (PhoneBrand.Equals("小米"))
                {
                    mobilePhone = new XiaoMI();
                }
                else if (PhoneBrand.Equals("锤子"))
                {
                    mobilePhone = new SmarTisan();
                }
                else
                {

                }
                return mobilePhone;
            }

        }

        static void Main(string[] args)//测试代码
        {
            MobilePhone mobilephone1 = MobielPhoneFactory.CreateMobilePhone("苹果");
            if (mobilephone1 != null)
                mobilephone1.print();
            MobilePhone mobilephone2 = MobielPhoneFactory.CreateMobilePhone("小米");
            if (mobilephone2 != null)
                mobilephone2.print();
            MobilePhone mobilephone3 = MobielPhoneFactory.CreateMobilePhone("锤子");
            if (mobilephone3 != null)
                mobilephone3.print();
            Console.Read();
        }
    }
}

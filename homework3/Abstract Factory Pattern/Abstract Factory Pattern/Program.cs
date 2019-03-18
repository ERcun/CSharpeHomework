using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    class Program
    {
        //抽象工厂类：提供创建不同品牌的手机屏幕和手机主板
        public abstract class AbstractFactory
        {
            //工厂生产屏幕
            public abstract Screen CreateScreen();
            //工厂生产主板
            public abstract MotherBoard CreateMotherBoard();
        }

        //手机屏幕和主板基类
        //屏幕抽象类：提供每一品牌的屏幕的继承
        public abstract class Screen
        {
            public abstract void print();
        }
        //主板抽象类：提供每一品牌的主板的继承
        public abstract class MotherBoard
        {
            public abstract void print();
        }

        //苹果手机屏幕和主板类
        public class AppleScreen : Screen
        {
            public override void print()
            {
                Console.WriteLine("苹果手机屏幕！");
            }
        }
        public class AppleMotherBoard : MotherBoard
        {
            public override void print()
            {
                Console.WriteLine("苹果手机主板！");
            }
        }

        //小米手机屏幕和主板类
        public class XiaoMiScreen : Screen
        {
            public override void print()
            {
                Console.WriteLine("小米手机屏幕！");
            }
        }
        public class XiaoMiMotherBoard : MotherBoard
        {
            public override void print()
            {
                Console.WriteLine("小米手机主板！");
            }
        }

        //苹果手机工厂类
        public class AppleFactory : AbstractFactory
        {
            public override Screen CreateScreen()
            {
                return new AppleScreen();
            }
            public override MotherBoard CreateMotherBoard()
            {
                return new AppleMotherBoard();
            }
        }

        //小米手机工厂类
        public class XiaoMiFactory : AbstractFactory
        {
            public override Screen CreateScreen()
            {
                return new XiaoMiScreen();
            }
            public override MotherBoard CreateMotherBoard()
            {
                return new XiaoMiMotherBoard();
            }
        }


        static void Main(string[] args)//测试代码
        {
            //小米工厂生产小米手机的屏幕和主板
            AbstractFactory xiaomiFactory = new XiaoMiFactory();
            Screen xiaomiScreen = xiaomiFactory.CreateScreen();
            xiaomiScreen.print();
            MotherBoard xiaomiMotherBoard = xiaomiFactory.CreateMotherBoard();
            xiaomiMotherBoard.print();

            //苹果工厂生产苹果手机屏幕和主板
            AbstractFactory appleFactory = new AppleFactory();
            Screen appleScreen = appleFactory.CreateScreen();
            appleScreen.print();
            MotherBoard appleMotherBoard = appleFactory.CreateMotherBoard();
            appleMotherBoard.print();

            Console.Read();
        }
    }
}

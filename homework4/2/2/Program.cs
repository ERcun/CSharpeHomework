using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {

        public static List<OrderDetails> orderDetails_list = OrderService.orderDetails_list;
        public static List<Order> list = OrderService.list;
        static void Main(string[] args)
        {
            Console.WriteLine("展示订单：");
            bool result = true;
            Order order = new Order();
            Init();

            while (result)
            {
                Console.WriteLine("请输入您需要的功能编号：");
                Console.WriteLine("1：添加订单，2：删除订单，3：修改订单，4：查询订单，0：退出");
                int id = Convert.ToInt32(Console.ReadLine().ToString());
                switch (id)
                {
                    case 0:
                        result = false;
                        break;
                    case 1:
                        Add();
                        break;
                    case 2:
                        Delete();
                        Init();
                        break;
                    case 3:
                        Update();
                        Init();
                        break;
                    case 4:
                        Select();
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine("结束");
        }

        //查询
        private static void Select()
        {
            Order order = new Order();
            Console.WriteLine("请输入需要查询的编号，1：编号，2：商品名称，3：客户名称");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("请输入要查询的编号");
                    int id = Convert.ToInt32(Console.ReadLine());
                    order.id = id;
                    Printf(Select__order(order));
                    break;
                case 2:
                    Console.WriteLine("请输入要查询的商品名称");
                    string ShopName = Console.ReadLine();
                    order.orderDetails = orderDetails_list.Find(x => x.ShopName == ShopName).id;
                    Printf(Select__order(order));
                    break;
                case 3:
                    Console.WriteLine("请输入要查询的用户名称");
                    string name = Console.ReadLine();
                    order.user = name;
                    Printf(Select__order(order));
                    break;
                default:
                    break;
            }
        }

        //删除
        private static void Delete()
        {

            bool result = true;
            while (result)
            {
                Console.WriteLine("请输入查询的订单编号");
                int num = Convert.ToInt32(Console.ReadLine());
                if (list.Where(x => x.id == num).ToList().Count > 0)
                {
                    Delete__order(num);
                    Console.WriteLine("删除完成");
                    result = false;
                }
                else
                {
                    Console.WriteLine("你输入的编号不存在，请重新输入");
                }
            }

        }

        //修改
        private static void Update()
        {
            Order order = new Order();
            bool result_update = true;

            while (result_update)
            {
                Console.WriteLine("请输入要修改的编号：");
                int id = Convert.ToInt32(Console.ReadLine());
                if (OrderService.list.Find(x => x.id == id) is null)
                {
                    Console.WriteLine("你输入的编号不存在，请重新输入");
                }
                else
                {
                    order.id = id;
                    result_update = false;
                }
                Console.WriteLine("请输入要修改的商品名称：");
                string ShopName = Console.ReadLine();
                if (CheckedShopName(ShopName))
                {
                    order.orderDetails = orderDetails_list.Find(x => x.ShopName == ShopName).id;
                }
                else
                {
                    Console.WriteLine("你输入的商品不存在不存在，请重新输入");
                }
            }
            Console.WriteLine("请输入要修改的用户：");
            order.user = Console.ReadLine();

            Update__order(order);
            Console.WriteLine("修改完成");
        }

        //初始化数据加载
        public static void Init()
        {
            list = list.OrderBy(x => x.id).ToList();
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("编号：" + list[i].id + "\t\t购买者：" + list[i].user + "\t\t商品名称：" + orderDetails_list.Find(x => x.id == list[i].orderDetails).ShopName);
                Console.WriteLine("");
            }
        }

        //新增
        public static void Add()
        {
            Order order = new Order();
            Console.WriteLine("请输入购买者");
            order.user = Console.ReadLine();
            bool result = true;
            while (result)
            {
                Console.WriteLine("请输入购买的商品");
                string ShopName = Console.ReadLine();
                if (CheckedShopName(ShopName))
                {
                    order.orderDetails = orderDetails_list.Find(x => x.ShopName == ShopName).id;
                    Add_order(order);
                    Console.WriteLine("添加完成");
                    Init();
                    result = false;
                }
                else
                {
                    Console.WriteLine("你输入的商品不存在不存在，请重新输入");
                }

            }

        }

        //打印
        public static void Printf(List<Order> list_order)
        {
            for (int i = 0; i < list_order.Count; i++)
            {
                Console.Write("编号：" + list_order[i].id + "\t\t购买者：" + list_order[i].user + "\t\t商品名称：" + orderDetails_list.Find(x => x.id == list_order[i].orderDetails).ShopName);
                Console.WriteLine("");
            }
        }

        //检查是否存输入的商品
        public static bool CheckedShopName(string name)
        {
            bool result = true;
            if (orderDetails_list.Where(x => x.ShopName == name).ToList().Count > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }

        //新增
        public static void Add_order(Order order)
        {
            order.id = list.Count + 1;
            list.Add(order);
        }
        //删除
        public static void Delete__order(int id)
        {
            Order order = list.Find(x => x.id == id);
            list.Remove(order);
        }
        //修改
        public static void Update__order(Order order)
        {
            list.RemoveAt(order.id - 1);
            list.Add(order);
        }
        //查询
        public static List<Order> Select__order(Order ord)
        {
            list = list.Where(x => (ord.id.ToString() != "0" && x.id == ord.id) || (ord.orderDetails.ToString() != "0" && x.orderDetails == ord.orderDetails) || (!string.IsNullOrEmpty(ord.user) && x.user == ord.user)).ToList();
            return list;
        }
    }
}

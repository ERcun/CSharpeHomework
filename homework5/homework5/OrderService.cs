using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework5
{
    //订单服务类
    public class OrderService: IComparable
    {
      public static List<Order> list = new List<Order>() {
            new Order(){id=1,user="张三",orderDetails=1 },
            new Order(){id=2,user="李四",orderDetails=2},
            new Order(){id=3,user="王五",orderDetails=3 },
            new Order(){id=4,user="张三",orderDetails=2 }
        };

        public static List<OrderDetails> orderDetails_list = new List<OrderDetails>()
        {
            new OrderDetails(){id=1,price="20.0$",ShopName="苹果",Remark="苹果来自日本！" },
            new OrderDetails(){id=2,price="28.0$",ShopName="香蕉",Remark="香蕉来自韩国！" },
            new OrderDetails(){id=3,price="40.0$",ShopName="橘子",Remark="橘子来自朝鲜！" }
        };
        //订单升序排序
        public List<Order> ShowOrder()
        {
            return list.OrderBy(x=>x.id).ToList();
        }
        //按照金额降序排序
        public List<OrderDetails2> ShowOrderMoney()
        {
            var result= from l in list
                        join o in orderDetails_list on l.orderDetails equals o.id orderby o.price
                        select new OrderDetails2 { id = l.id, user = l.user, ShopName=o.ShopName, price=o.price, orderDetails=l.orderDetails};

            return result.ToList();
        }

       
    }
}

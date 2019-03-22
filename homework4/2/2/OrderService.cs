using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    //订单服务类
    public class OrderService
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
       
    }
}

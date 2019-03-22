using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    //订单
   public class Order
    {
        //编号
        public int id { get; set; }
       
        //购买者
        public string user { get; set; }

        public int orderDetails { get; set; }
    }
}

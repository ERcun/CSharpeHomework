using System;
using System.Collections.Generic;
using System.Text;

namespace _2
{
    //订单明细
   public class OrderDetails
    {
        public int id { get; set; }

        public string price { get; set; }
        //商品名称
        public string ShopName { get; set; }

        public string Remark { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace homework5
{
    //订单
   public class Order
    {
        //编号
        public int id { get; set; }
       
        //购买者
        public string user { get; set; }

        public int orderDetails { get; set; }

        public override bool Equals(System.Object obj)
        {
            // If parameter cannot be cast to ThreeDPoint return false:
            Order p = obj as Order;
            if ((object)p == null)
            {
                return false;
            }

            // Return true if the fields match:
            return base.Equals(obj) && OrderService.list.Find(x => x.orderDetails == p.orderDetails && x.user == p.user) != null;
        }

        public bool Equals(Order p)
        {
            return base.Equals((Order)p) && OrderService.list.Find(x=>x.orderDetails==p.orderDetails&&x.user==p.user) != null;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode() ^ orderDetails;
        }
    }
    public class OrderDetails2 : Order
    {
        public string price { get; set; }
        //商品名称
        public string ShopName { get; set; }
    }
}

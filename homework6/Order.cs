using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace homework6
{
    [Serializable]      // 表示该类可以被序列化
    [XmlRoot("ArrayOfOrder")]    // 设置为XML中的根元素名称
    public class Order
    {
        private List<OrderDetail> orderList = new List<OrderDetail>();
        //构造函数
        public Order() { }
        //订单：订单号，客户名称
        public Order(uint orderId, Customer customer)
        {
            Id = orderId;
            Customer = customer;
        }

        public uint Id { get; set; }
        public Customer Customer { get; set; }

        public List<OrderDetail> Details
        {
            get => this.orderList;
        }

        public void AddDetails(OrderDetail orderDetail)
        {
            if (this.Details.Contains(orderDetail))
            {
                throw new Exception($"orderDetails-{orderDetail.Id} is already existed!");
            }
            orderList.Add(orderDetail);
        }

        public void RemoveDetails(uint orderDetailId)
        {
            orderList.RemoveAll(d => d.Id == orderDetailId);
        }
    }
}

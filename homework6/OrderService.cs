using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;


namespace homework6
{
    /// 实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询)
    public  class OrderService
    {

        private List<Order> orderList;
        /// <summary>
        /// OrderService constructor
        /// </summary>
        public OrderService()
        {
            orderList = new List<Order>();
        }
        /// <summary>
        /// add new order
        /// </summary>
        /// <param name="order">the order will be added</param>
        public void AddOrder(Order order)
        {
            foreach (Order o in orderList)
            {
                if (o.Id.Equals(order.Id))
                {
                    throw new Exception($"order-{order.Id} is already existed!");
                }
            }
            orderList.Add(order);
        }

        /// <summary>
        /// query by orderId
        /// </summary>
        /// <param name="orderId">id of the order to find</param>
        /// <returns>List<Order></returns> 
        public Order GetById(uint orderId)
        {
            foreach (Order o in orderList)
            {
                if (o.Id == orderId)
                {
                    return o;
                }
            }
            return null;
        }

        /// <summary>
        /// remove order
        /// </summary>
        /// <param name="orderId">id of the order which will be removed</param> 
        public void RemoveOrder(uint orderId)
        {
            Order order = GetById(orderId);
            if (order == null) return;
            orderList.Remove(order);
        }

        /// <summary>
        /// query all orders
        /// </summary>
        /// <returns>List<Order>:all the orders</returns> 
        public List<Order> QueryAllOrders()
        {
            return orderList;
        }


        /// <summary>
        /// query by goodsName
        /// </summary>
        /// <param name="goodsName">the name of goods in order's orderDetail</param>
        /// <returns></returns> 
        public List<Order> QueryByGoodsName(string goodsName)
        {
            List<Order> result = new List<Order>();
            foreach (Order order in orderList)
            {
                foreach (OrderDetail detail in order.Details)
                {
                    if (detail.Goods.Name == goodsName)
                    {
                        result.Add(order);
                        break;
                    }
                }
            }
            return result;
        }


        //序列化为XML
        public void Export()
        {
            XmlSerializer xmlser = new XmlSerializer(typeof(Order));
            String xmlFileName = "./order.xml";
            FileStream fs = new FileStream(xmlFileName, FileMode.Create, FileAccess.ReadWrite);
            foreach (Order order in orderList)
            {
                xmlser.Serialize(fs, order);
            }
            fs.Close();
        }

        //从XML文件中载入订单
        public void Import()
        {
            String xmlFileName = "./order.xml";
            FileStream fs = new FileStream(xmlFileName, FileMode.Open, FileAccess.Read);
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            Dictionary<uint, Order> orderDict1 = xmlser.Deserialize(fs) as Dictionary<uint, Order>;
            foreach (Order order in orderList)
            {
                AddOrder(order);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5
{
   public interface IComparable
    {
        //订单升序排序
        List<Order> ShowOrder();
        //按照金额降序排序
        List<OrderDetails2> ShowOrderMoney();
    }
}

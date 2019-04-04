using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
   public class Goods
    {
        private double price;
        public Goods() { }
        public Goods(uint goodId, string goodName, double goodPrice)
        {
            Id = goodId;
            Name = goodName;
            Price = goodPrice;
        }

        public uint Id { get; set; }

        public string Name { get; set; }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("value must >= 0!");
                price = value;
            }
        }
    }
}

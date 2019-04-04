using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class Customer
    {
        public Customer() { }
        public uint Id { get; set; }

        public string Name { get; set; }

        public Customer(uint id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}

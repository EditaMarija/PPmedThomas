using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPmedThomas
{
    internal class Guest
    {
        public Room Room { get; set; }
        public string Name { get; set; }

        public Guest(string name)
        {
            Name = name;
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Events.Inventory.Core
{
    public class ProductShortageEventArgs : EventArgs
    {
        public string Name { get; }
        public int ToBuy { get; }

        public ProductShortageEventArgs(string name, int toBuy)
        {
            Name = name;
            ToBuy = toBuy;
        }
    }
}

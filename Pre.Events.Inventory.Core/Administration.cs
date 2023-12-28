using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Events.Inventory.Core
{
    public class Administration
    {
        public void ProductShortageHandlerAdministration(object sender, ProductShortageEventArgs e)
        {
            Console.WriteLine($"There is a shortage of {e.Name}");
        }
    }
}

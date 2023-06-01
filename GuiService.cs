using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class GuiService: IGuiService
    {
        public GuiService() { }

        public void ShowCurrentAmount(int amount)
        {
            Console.WriteLine($"Current Amount {amount}");
        }
    }
}

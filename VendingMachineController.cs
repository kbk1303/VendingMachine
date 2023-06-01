using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class VendingMachineController : IVendingMachineController
    {   
        private readonly IGuiService _guiService;
        private readonly IMoneyService _moneyService;

        public VendingMachineController(IMoneyService money, IGuiService gui) {
            _guiService = gui;
            _moneyService = money;
        }

        public void InsertMoney(int amount)
        {
            this._guiService.ShowCurrentAmount(this._moneyService.CurrentAmount(amount));
        }
    }

}

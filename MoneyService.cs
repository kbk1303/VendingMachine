using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    internal class MoneyService : IMoneyService
    {
        private int currentAmount = 0;
        public int CurrentAmount(int amount)
        {
            currentAmount += amount;
            return currentAmount;
        }
    }
}

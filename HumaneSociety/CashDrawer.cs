using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class CashDrawer
    {
        private int currentMoney;
        public void AddMoney()
        {
            currentMoney = currentMoney + 2;
        }
    }
}

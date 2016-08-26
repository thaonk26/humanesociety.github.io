using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class HumaneSociety
    {
        UserInterface ui = new UserInterface();
        CashDrawer cashDrawer;
        DataBase dataBase;
        public void RunShelter()
        {
            ui.Decision();
        }
    }
}

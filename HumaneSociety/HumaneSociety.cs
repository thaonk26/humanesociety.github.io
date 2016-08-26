using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class HumaneSociety
    {        
        CashDrawer cashDrawer;
        DataBase dataBase;
        public void RunShelter()
        {
            cashDrawer = new CashDrawer();
            dataBase = new DataBase();
        }
            
    }
    
}

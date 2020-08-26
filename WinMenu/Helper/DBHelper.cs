using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinMenu.Database;

namespace WinMenu.Helper
{
    public class DBHelper
    {
        private static WinMenuEntities Context = new WinMenuEntities();
        public static WinMenuEntities GetContext()
        {
            return Context;
        }
    }
}

using Lab20.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab20
{
    class Manager
    {
        public static DBEntities db { get; set; } = new DBEntities();
        public static Frame MainFrame { get; set; }
    }
}

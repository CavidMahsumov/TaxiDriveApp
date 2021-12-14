using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiDriveApp.Models
{
    public class Helper
    {
        static public MainWindow mainWindow { get; set; }
        public Helper()
        {
            mainWindow = new MainWindow();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TaxiDriveApp.Models;
using TaxiDriveApp.ViewModel;

namespace TaxiDriveApp.View
{
    /// <summary>
    /// Interaction logic for LoginUserCOntrol.xaml
    /// </summary>
    public partial class LoginUserCOntrol : UserControl
    {
        public LoginUserCOntrol()
        {
            InitializeComponent();
            this.DataContext = new LoginUserControlViewModel(this);
        }
    }
}

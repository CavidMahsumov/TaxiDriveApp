using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using TaxiDriveApp.Commands;

namespace TaxiDriveApp.ViewModel
{
   public class MainWindowViewModel:BaseViewModel
    {
        public RelayCommand MouseDown { get; set; }
        public RelayCommand MouseDownForReset { get; set; }
        public RelayCommand MouseDownForSend { get; set; }

        public MainWindowViewModel(MainWindow mainWindow)
        {
            MouseDown = new RelayCommand((sender) =>
            {

                Storyboard beginStoryboard = new Storyboard();
                beginStoryboard = mainWindow.FindResource("Storyboard1") as Storyboard;
                beginStoryboard.Begin();

            });
            MouseDownForReset = new RelayCommand((sender) => {

                Storyboard beginStoryboard = new Storyboard();
                beginStoryboard = mainWindow.FindResource("ResetStoryBoard") as Storyboard;
                beginStoryboard.Begin();


            });
            MouseDownForSend = new RelayCommand((sender) =>
            {
                //mainWindow.Login.Visibility = Visibility.Visible;
                


            });
        }
    }
}

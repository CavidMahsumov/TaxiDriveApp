using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Animation;
using TaxiDriveApp.Commands;
using TaxiDriveApp.View;

namespace TaxiDriveApp.ViewModel
{
    public class LoginUserControlViewModel : BaseViewModel
    {
        public RelayCommand MouseDownPulseButton { get; set; }
        public RelayCommand MouseDownResetButton { get; set; }
        public RelayCommand MouseDownSendButton { get; set; }
        public RelayCommand MouseDownForRegisterNextButton { get; set; }
        public LoginUserControlViewModel(LoginUserCOntrol loginUserControl)
        {
          
           
            MouseDownPulseButton = new RelayCommand((sender) =>
            {

                Storyboard beginStoryboard = new Storyboard();
                beginStoryboard = loginUserControl.FindResource("Storyboard1") as Storyboard;
                beginStoryboard.Begin();

            });
            MouseDownResetButton = new RelayCommand((sender) =>
            {

                Storyboard beginStoryboard = new Storyboard();
                beginStoryboard = loginUserControl.FindResource("ResetStoryBoard") as Storyboard;
                beginStoryboard.Begin();

            });
            MouseDownSendButton = new RelayCommand((sender) =>
            {

                for (int i = 0; i < loginUserControl.ResetPassword.Children.Count; i++)
                {
                    loginUserControl.ResetPassword.Children.RemoveAt(i);
                }

                for (int i = 0; i < loginUserControl.Login.Children.Count; i++)
                {
                    loginUserControl.Login.Children.RemoveAt(i);
                }
                for (int i = 0; i < loginUserControl.Register.Children.Count; i++)
                {
                    loginUserControl.Register.Children.RemoveAt(i);
                }
                
                LoginUserCOntrol loginUserCOntrol = new LoginUserCOntrol();
                loginUserControl.MainGrid.Children.Add(loginUserCOntrol);

            });
            MouseDownForRegisterNextButton = new RelayCommand((sender) =>
            {
                for (int i = 0; i < loginUserControl.ResetPassword.Children.Count; i++)
                {
                    loginUserControl.ResetPassword.Children.RemoveAt(i);
                }

                for (int i = 0; i < loginUserControl.Login.Children.Count; i++)
                {
                    loginUserControl.Login.Children.RemoveAt(i);
                }
                for (int i = 0; i < loginUserControl.Register.Children.Count; i++)
                {
                    loginUserControl.Register.Children.RemoveAt(i);
                }
                for (int i = 0; i <= loginUserControl.MainGrid.Children.Count; i++) 
                {
                    loginUserControl.MainGrid.Children.RemoveAt(i);
                }
                LoginUserCOntrol loginUserCOntrol = new LoginUserCOntrol();
                loginUserControl.MainGrid.Children.Add(loginUserCOntrol);
                

            });
        }
    }
}

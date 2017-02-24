using Plugin.AutoLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AutoLoginSimple
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
#if DEBUG
            entry_email.Text = "mabrouk@mahdhi.com";
            entry_password.Text = "password";
#endif

        }

        private void Connect_clicked(object sender, EventArgs e)
        {
            string msg = "Please verify your login and your password!";
            if (entry_email.Text.ToLower() != "mabrouk@mahdhi.com")
            {
                DisplayAlert("Hey!", msg, "Ok");
                return;
            }
            if (entry_password.Text.ToLower() != "password")
            {
                DisplayAlert("Hey!", msg, "Ok");
                return;
            }

            // Test if user is already saved 
            if (CrossAutoLogin.Current.UserIsSaved == false)
            {
                CrossAutoLogin.Current.SaveUserInfos(entry_email.Text, entry_password.Text);
            }

            Navigation.PushModalAsync(new HomePage());
        }

    }
}

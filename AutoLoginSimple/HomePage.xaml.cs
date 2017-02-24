using Plugin.AutoLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AutoLoginSimple
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            //Show user mail 
            label_home.Text = $"Welcome! the saved mail is : {CrossAutoLogin.Current.UserEmail}";
        }
        private void Disconnect_clicked(object sender, EventArgs e)
        {
            CrossAutoLogin.Current.DeleteUserInfos();
            Navigation.PopModalAsync();
        }
    }
}

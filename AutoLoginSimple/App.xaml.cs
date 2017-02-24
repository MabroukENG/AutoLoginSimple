using Plugin.AutoLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AutoLoginSimple
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            // If user is saved ; HomePage is automaticly open
            if (CrossAutoLogin.Current.UserIsSaved)
                MainPage = new AutoLoginSimple.HomePage();
            else MainPage = new AutoLoginSimple.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

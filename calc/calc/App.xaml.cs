using calcShell;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calc
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new shell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

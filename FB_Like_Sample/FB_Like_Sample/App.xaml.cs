using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FB_Like_Sample.Views;
using FB_Like_Sample.Views.Templates;

namespace FB_Like_Sample
{
    public partial class App : Application
    {

        public App()
        {
            Device.SetFlags(new string[] { "MediaElement_Experimental" });

            InitializeComponent();

            MainPage = new FB_LoginPage();
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

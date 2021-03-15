using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamIntro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new RegisterPage();
            // MainPage = new BookingsCarouselPage();
            MainPage = new BookingsTabbedPage();
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

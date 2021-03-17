using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamIntro
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailXamlPage : MasterDetailPage
    {
        public MasterDetailXamlPage()
        {
            InitializeComponent();

            if(Device.Idiom != TargetIdiom.Phone)
            {
                this.MasterBehavior = MasterBehavior.Split;
            }
            masterPage.ButtonHotel.Clicked += ButtonHotel_Clicked;
            masterPage.ButtonFlight.Clicked += ButtonFlight_Clicked;
            masterPage.ButtonCab.Clicked += ButtonCab_Clicked;
        }

        private void ButtonFlight_Clicked(object sender, EventArgs e)
        {
            this.Detail = new NavigationPage(new FlightPage());
            if (Device.Idiom == TargetIdiom.Phone)
                this.IsPresented = false;
        }

        private void ButtonHotel_Clicked(object sender, EventArgs e)
        {
            this.Detail = new NavigationPage(new HotelPage());
            if (Device.Idiom == TargetIdiom.Phone)
                this.IsPresented = false;
        }

        private void ButtonCab_Clicked(object sender, EventArgs e)
        {
            this.Detail = new NavigationPage(new CabPage());
            if (Device.Idiom == TargetIdiom.Phone)
                this.IsPresented = false;
        }

    }
}
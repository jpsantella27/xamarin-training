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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if(Device.Idiom != TargetIdiom.Phone)
            {
               
            }
        }

        public void ButtonRegister_Clicked(object sender, EventArgs e)
        {
            var uname = EntryUserName.Text;
            var pwd = EntryPassword.Text;
            var email = EntryEmailAddress.Text;
            var mobile = EntryMobileNumber.Text;

            var msg = $"User name: {uname}\nPassword : {pwd}\nEmail Address: {email}\nMobile: {mobile}";

            DisplayAlert("Register", msg, "OK");
        }

        public void ButtonClear_Clicked(object sender, EventArgs e)
        {
            EntryUserName.Text = string.Empty;
            EntryPassword.Text = string.Empty;
            EntryEmailAddress.Text = string.Empty;
            EntryMobileNumber.Text = string.Empty;
        }
    }
}
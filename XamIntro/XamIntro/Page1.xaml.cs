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
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        async void ContinueButton_Clicked(object sender, EventArgs e)
        {
            var uname = EntryName.Text;
            //await Navigation.PushModalAsync(new Page2(uname));
            await Navigation.PushAsync(new Page2(uname));
        }
    }
}
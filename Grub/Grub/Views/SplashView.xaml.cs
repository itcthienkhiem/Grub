using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grub.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashView : ContentPage
    {
        public SplashView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        protected override async void OnAppearing()
        {
            //Online_Groceries-cuate.png
            base.OnAppearing();
            await splashImage.ScaleTo(1, 2000);
         //   await splashImage.ScaleTo(0.9, 1500,Easing.Linear);
         //   await splashImage.ScaleTo(150, 1200, Easing.Linear);
            Application.Current.MainPage = new NavigationPage(new Login());



        }

    }
}
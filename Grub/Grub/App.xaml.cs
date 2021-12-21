using Grub.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
[assembly:ExportFont("Roboto-Black.ttf", Alias = "Roboto-Black")]
[assembly: ExportFont("Roboto-BlackItalic.ttf", Alias = "Roboto-BlackItalic")]
[assembly: ExportFont("Roboto-Bold.ttf", Alias = "Roboto-Bold")]
[assembly: ExportFont("Roboto-BoldItalic.ttf", Alias = "Roboto-BoldItalic")]
[assembly: ExportFont("Roboto-Italic.ttf", Alias = "Roboto-Italic")]
[assembly: ExportFont("Roboto-Light.ttf", Alias = "Roboto-Light")]
[assembly: ExportFont("Roboto-LightItalic.ttf", Alias = "Roboto-LightItalic")]
[assembly: ExportFont("Roboto-MediumItalic.ttf", Alias = "Roboto-MediumItalic")]
[assembly: ExportFont("Roboto-Regular.ttf", Alias = "Roboto-Regular")]
[assembly: ExportFont("Roboto-Thin.ttf", Alias = "Roboto-Thin")]
[assembly: ExportFont("Roboto-ThinItalic.ttf", Alias = "Roboto-ThinItalic")]

namespace Grub
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTQxODA2QDMxMzkyZTMzMmUzMGtneVBaNHRMYWVJaHJZMmNmZkYyVVdqQmQyQ1U1WjVpdVMvK0EwT2dQYUE9");

            InitializeComponent();

            MainPage = new NavigationPage(new SplashView());
           
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

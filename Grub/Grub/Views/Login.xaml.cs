using Grub.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Extensions;

namespace Grub.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            ShowMessage();
        }
        private async void ShowMessage()
        {
            await Navigation.PushPopupAsync(new BottomSheetControls());
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushPopupAsync(new BottomSheetControls());
        }
    }
}
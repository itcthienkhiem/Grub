using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace Grub.Components
{
  

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BottomSheetControls : Rg.Plugins.Popup.Pages.PopupPage
    {
        public BottomSheetControls()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopPopupAsync();
        }
    }
}
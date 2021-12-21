using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Grub.Resource
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainResource : ResourceDictionary
    {
        public MainResource()
        {
            InitializeComponent();
        }
    }
}
using FB_Like_Sample.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FB_Like_Sample.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FB_ProfilePage : ContentPage
    {
        public FB_ProfilePage(object bindingContext)
        {
            BindingContext = bindingContext;

            InitializeComponent();
        }
    }
}
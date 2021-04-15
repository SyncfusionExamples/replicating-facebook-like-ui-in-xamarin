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
    public partial class FB_FriendProfilePage : ContentPage
    {
        public FB_FriendProfilePage(object bindingContext)
        {
            BindingContext = bindingContext;

            InitializeComponent();
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
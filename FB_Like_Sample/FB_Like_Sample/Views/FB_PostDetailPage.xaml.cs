using FB_Like_Sample.Models;
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
    public partial class FB_PostDetailPage : ContentPage
    {
        Post post;
        public FB_PostDetailPage(object bindingContext)
        {
            BindingContext = bindingContext;
            post = BindingContext as Post;
            
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            post.MoreIconVisibility = false;
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            post.MoreIconVisibility = true;
            await Navigation.PopModalAsync();
        }
    }
}
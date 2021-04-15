using FB_Like_Sample.Models;
using FB_Like_Sample.ViewModels;
using Syncfusion.XForms.Buttons;
using Syncfusion.XForms.PopupLayout;
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
    public partial class FB_PostHomePage : ContentPage
    {
        public FB_PostHomePage(object bindingContext)
        {
            BindingContext = bindingContext;

            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            listView.RefreshView();
            base.OnAppearing();
        }
    }
}
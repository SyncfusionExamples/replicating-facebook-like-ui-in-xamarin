using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using FB_Like_Sample.Models;
using FB_Like_Sample.ViewModels;

namespace FB_Like_Sample.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        FBViewModel fBViewModel;
        List<HomeMenuItem> menuItems;

        public MainPage(FBViewModel viewModel)
        {
            InitializeComponent();

            fBViewModel = viewModel;

            BindingContext = fBViewModel.LoggedInUser;

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Home, Title="Home" },
                new HomeMenuItem {Id = MenuItemType.Profile, Title="Profile" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemTapped += async (sender, e) =>
            {
                if (e.ItemData == null)
                    return;

                var id = (int)((HomeMenuItem)e.ItemData).Id;

                await NavigateFromMenu(id);
            };


            MasterBehavior = MasterBehavior.Popover;
            Detail = new NavigationPage(new FB_PostHomePage(fBViewModel));
            MenuPages.Add((int)MenuItemType.Home, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Home:
                        MenuPages.Add(id, new NavigationPage(new FB_PostHomePage(fBViewModel)));
                        break;
                    case (int)MenuItemType.Profile:
                        MenuPages.Add(id, new NavigationPage(new FB_ProfilePage(fBViewModel.LoggedInUser)));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;                   
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }

        private async void SfButton_Clicked(object sender, EventArgs e)
        {
            fBViewModel.UserID = string.Empty;
            fBViewModel.Password = string.Empty;

            await Navigation.PopModalAsync();
        }
    }
}
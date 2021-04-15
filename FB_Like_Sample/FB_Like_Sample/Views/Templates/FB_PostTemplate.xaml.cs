using FB_Like_Sample.Models;
using FB_Like_Sample.ViewModels;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FB_Like_Sample.Views.Templates
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FB_PostTemplate : Grid
    {
        Post post;
        public Page MainPage
        {
            get
            {
                return Application.Current.MainPage;
            }
        }

        public FB_PostTemplate()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            post = this.BindingContext as Post;
            base.OnBindingContextChanged();
        }

        private void rating_ValueChanged(object sender, Syncfusion.SfRating.XForms.ValueEventArgs e)
        {
            if (post.AllowReactionUpdate)
            {
                post.ReactionUpdate(e.Value);
                post.AllowReactionUpdate = false;
            }

            popupLayout.Dismiss();
        }

        private void reactionButton_Clicked(object sender, EventArgs e)
        {
            post.AllowReactionUpdate = true;
            popupLayout.ShowRelativeToView(reactionButton, RelativePosition.AlignTop, 0, 0);
        }

        private void popupLayout_Closed(object sender, EventArgs e)
        {
            post.ReactionIndex = 0;
        }

        private void moreItemsButton_Clicked(object sender, EventArgs e)
        {
            actionPopupLayout.ShowRelativeToView(moreItemsButton, RelativePosition.AlignBottomLeft, 40, 0);
        }

        private void reportProblemButton_Clicked(object sender, EventArgs e)
        {
            actionPopupLayout.Dismiss();
            MainPage.DisplayAlert("Alert", "Problem reported", "OK");
        }

        private void shareActionButton_Clicked(object sender, EventArgs e)
        {
            actionPopupLayout.Dismiss();
            MainPage.DisplayAlert("Alert", "Shared this post in your timeline", "OK");
        }

        private async void deleteActionButton_Clicked(object sender, EventArgs e)
        {
            actionPopupLayout.Dismiss();
            await Task.Delay(500);
            post.ViewModel.Posts.Remove(post);
        }

        private async void openActionButton_Clicked(object sender, EventArgs e)
        {
            actionPopupLayout.Dismiss();
            post.OpenPost(null);
        }
    }
}
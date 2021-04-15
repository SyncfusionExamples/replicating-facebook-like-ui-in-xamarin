using FB_Like_Sample.Views;
using Syncfusion.ListView.XForms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace FB_Like_Sample.Models
{
    public class Person : BaseModel
    {

        #region Fields

        private string userID;
        private string password;
        private string userName;
        private string profilePicture;
        private string bannerPicture;
        private string statusMessage;
        private ObservableCollection<Post> posts;
        private List<Person> friends;
        private List<string> images;
        private Dictionary<AboutType, string> about;
        private Command postImageSelectionChangedCommand;
        private Command friendSelectionChangedCommand;

        #endregion

        #region Properties

        public string UserID
        {
            get { return userID; }
            set { SetProperty(ref userID, value); }
        }

        public string Password
        {
            get { return password; }
            set { SetProperty(ref password, value); }
        }

        public string UserName
        {
            get { return userName; }
            set { SetProperty(ref userName, value); }
        }

        public string ProfilePicture
        {
            get { return profilePicture; }
            set { SetProperty(ref profilePicture, value); }
        }

        public string BannerPicture
        {
            get { return bannerPicture; }
            set { SetProperty(ref bannerPicture, value); }
        }

        public string StatusMessage
        {
            get { return statusMessage; }
            set { SetProperty(ref statusMessage, value); }
        }

        public Dictionary<AboutType, string> About
        {
            get { return about; }
            set { SetProperty(ref about, value); }
        }

        public List<string> Images
        {
            get { return images; }
            set { SetProperty(ref images, value); }
        }

        public List<Person> Friends
        {
            get { return friends; }
            set { SetProperty(ref friends, value); }
        }

        public ObservableCollection<Post> Posts
        {
            get { return posts; }
            set { SetProperty(ref posts, value); }
        }
        
        public Page MainPage
        {
            get
            {
                return Application.Current.MainPage;
            }
        }

        #endregion

        #region Commands

        /// <summary>
        /// Gets or sets the command that will be executed when particular post image selected. 
        /// </summary>
        public Command PostImageSelectionChangedCommand
        {
            get
            {
                return this.postImageSelectionChangedCommand ?? (this.postImageSelectionChangedCommand = new Command(PostImageSelected));
            }
        }

        /// <summary>
        /// Gets or sets the command that will be executed when particular friend selected. 
        /// </summary>
        public Command FriendSelectionChangedCommand
        {
            get
            {
                return this.friendSelectionChangedCommand ?? (this.friendSelectionChangedCommand = new Command(FriendSelected));
            }
        }

        #endregion

        #region Constructor

        public Person()
        {
            Posts = new ObservableCollection<Post>();
            Friends = new List<Person>();
        }

        #endregion

        #region Methods

        private async void PostImageSelected(object obj)
        {
            var listView = obj as SfListView;

            Post post = Posts.Where(post1 => post1.Picture == listView.SelectedItem.ToString()).FirstOrDefault() as Post;

            if (post != null)
            {
                await MainPage.Navigation.PushModalAsync(new NavigationPage(new FB_PostDetailPage(post)));
            }
        }

        private async void FriendSelected(object obj)
        {
            var listView = obj as SfListView;

            Person person = listView.SelectedItem as Person;

            if (person != null)
            {
                await MainPage.Navigation.PushModalAsync(new NavigationPage(new FB_FriendProfilePage(person)));
            }
        }

        #endregion
    }

    public enum AboutType
    {
        Position,
        Work,
        Education,
        Living,
        Native,
        Joined,
        Following,
        Followers
    }
}

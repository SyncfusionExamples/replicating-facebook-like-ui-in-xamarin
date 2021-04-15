using FB_Like_Sample.Interface;
using FB_Like_Sample.Models;
using FB_Like_Sample.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace FB_Like_Sample.ViewModels
{
    public class FBViewModel : BaseModel
    {
        #region Fields

        private ObservableCollection<Post> posts;
        private string userID;
        private string password;
        private ObservableCollection<Person> persons;
        private string errorText;
        private string newPostText;
        private int postId = 1;

        #endregion

        #region Properties

        public ObservableCollection<Post> Posts
        {
            get { return posts; }
            set { SetProperty(ref posts, value); }
        }

        public ObservableCollection<Person> Persons
        {
            get { return persons; }
            set { SetProperty(ref persons, value); }
        }

        public string NewPostText
        {
            get { return newPostText; }
            set { SetProperty(ref newPostText, value); }
        }

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

        public string ErrorText
        {
            get { return errorText; }
            set { SetProperty(ref errorText, value); }
        }

        public Person LoggedInUser { get; set; }

        public Page MainPage 
        {
            get
            {
                return Application.Current.MainPage;
            }
        }

        #endregion

        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Log In button is clicked.
        /// </summary>
        public Command LoginCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the forgot password button is clicked.
        /// </summary>
        public Command ForgotPasswordCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the sign up button is clicked.
        /// </summary>
        public Command SignUpCommand { get; set; }

        /// <summary>
        /// Gets or sets the command that is executed when the add new post button is clicked.
        /// </summary>
        public Command AddNewPostCommand { get; set; }

        #endregion

        #region Constructor

        public FBViewModel()
        {
            PopulateData();

            this.LoginCommand = new Command(this.LoginClicked);
            this.ForgotPasswordCommand = new Command(this.ForgotPasswordClicked);
            this.SignUpCommand = new Command(this.SignUpClicked);
            this.AddNewPostCommand = new Command(this.AddNewPost);
        }

        #endregion

        #region Methods

        #region Commands

        /// <summary>
        /// Invoked when the forgot password button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void ForgotPasswordClicked(object obj)
        {
            if (string.IsNullOrEmpty(UserID))
            {
                MainPage.DisplayAlert("Alert", "Please enter user id", "OK");
            }
            else
            {
                var result = Persons.Where(person => person.UserID == UserID).FirstOrDefault();

                if (result is Person)
                {
                    MainPage.DisplayAlert("Alert", "Your password sent to your e-mail address.", "OK");
                }
                else
                {
                    MainPage.DisplayAlert("Alert", "Please enter valid user id", "OK");
                }
            }
        }

        /// <summary>
        /// Invoked when the add new post button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void AddNewPost(object obj)
        {
            if(string.IsNullOrEmpty(NewPostText))
            {
                MainPage.DisplayAlert("Alert", "Please add a message.", "OK");

                return;
            }

            Post post = new Post(this)
            {
                ID = postId,
                Owner = LoggedInUser
            };

            MessagePostViewModel.AddNewPost(ref post, LoggedInUser, NewPostText);

            Posts.Insert(0, post);

            NewPostText = string.Empty;

            IKeyboardHelper dependencyService = DependencyService.Get<IKeyboardHelper>();
            dependencyService?.HideKeyboard();
        }

        /// <summary>
        /// Invoked when the forgot sign up button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private void SignUpClicked(object obj)
        {
            MainPage.DisplayAlert("Alert", "This module will be implemented soon.", "OK");
        }

        /// <summary>
        /// Invoked when the Log In button is clicked.
        /// </summary>
        /// <param name="obj">The Object</param>
        private async void LoginClicked(object obj)
        {
            ErrorText = string.Empty;

            if (string.IsNullOrEmpty(UserID) && string.IsNullOrEmpty(Password))
            {
                ErrorText = "Please enter user id and password";
                return;
            }

            var result = Persons.Where(person => person.UserID == UserID).FirstOrDefault();

            if (result is Person)
            {
                Person person = result as Person;

                if (person.Password == Password)
                {
                    LoggedInUser = person;

                    await MainPage.Navigation.PushModalAsync(new MainPage(this));
                }
                else
                {
                    ErrorText = "Incorrect password";
                }
            }
            else
            {
                ErrorText = "Incorrect user id";
            }
        }

        #endregion

        private void PopulateData()
        {
            Persons = new ObservableCollection<Person>();
            var fbPosts = new ObservableCollection<Post>();

            string[] names = new string[] {"Micheal", "James", "Prince", "Victor", "Susan" };

            for (int i = 0; i < names.Length; i++)
            {
               Persons.Add(CreatePerson(names[i], i.ToString()));
            }

            //Set friends for each person. 
            foreach (var person in Persons)
            {
                person.Friends = Persons.Where(user => user != person).ToList();
            }

            for (int i = 0; i < 5; i++)
            {
                //Add message type posts for each person
                foreach (var person in Persons)
                {
                    Post post = CreatePost(person);
                    post.Owner = person;

                    fbPosts.Add(post);
                    person.Posts.Add(post);
                }
            }

            Posts = new ObservableCollection<Post>(fbPosts.OrderBy(post => post.PostedOn));
        }

        #region Create Person

        private Person CreatePerson(string name, string id)
        {
            Person person = new Person();
            person.UserID = "User00" + id;
            person.Password = "User00" + id;
            person.UserName = name;
            person.ProfilePicture = "User00" + id + ".png";
            person.BannerPicture = "User00" + id + "Banner.png";

            //Adding AboutUs details for each person.
            UserViewModel.AddAboutUsForPerson(person);

            //Adding status images collection for each person.
            UserViewModel.AddStatusImagesForPerson(person);

            return person;
        }

        #endregion

        #region Create Post

        private Post CreatePost(Person person)
        {
            Post post = new Post(this);
            post.ID = postId;

            switch (postId)
            {
                case 1:
                    MessagePostViewModel.CreateMessagePost001(ref post, person);
                    break;

                case 2:
                    MessagePostViewModel.CreateMessagePost002(ref post, person);
                    break;

                case 3:
                    MessagePostViewModel.CreateMessagePost003(ref post, person);
                    break;

                case 4:
                    MessagePostViewModel.CreateMessagePost004(ref post, person);
                    break;

                case 5:
                    MessagePostViewModel.CreateMessagePost005(ref post, person);
                    break;

                case 6:
                    PicturePostViewModel.CreatePicturePost001(ref post, person, person.Images[0]);
                    break;

                case 7:
                    PicturePostViewModel.CreatePicturePost002(ref post, person, person.Images[0]);
                    break;

                case 8:
                    PicturePostViewModel.CreatePicturePost003(ref post, person, person.Images[0]);
                    break;

                case 9:
                    PicturePostViewModel.CreatePicturePost004(ref post, person, person.Images[0]);
                    break;

                case 10:
                    PicturePostViewModel.CreatePicturePost005(ref post, person, person.Images[0]);
                    break;

                case 11:
                    PicturePostViewModel.CreatePicturePost006(ref post, person, person.Images[1]);
                    break;

                case 12:
                    PicturePostViewModel.CreatePicturePost007(ref post, person, person.Images[1]);
                    break;

                case 13:
                    PicturePostViewModel.CreatePicturePost008(ref post, person, person.Images[1]);
                    break;

                case 14:
                    PicturePostViewModel.CreatePicturePost009(ref post, person, person.Images[1]);
                    break;

                case 15:
                    PicturePostViewModel.CreatePicturePost010(ref post, person, person.Images[1]);
                    break;

                case 16:
                    MessagePostViewModel.CreateMessagePost006(ref post, person);
                    break;

                case 17:
                    MessagePostViewModel.CreateMessagePost007(ref post, person);
                    break;

                case 18:
                    MessagePostViewModel.CreateMessagePost008(ref post, person);
                    break;

                case 19:
                    MessagePostViewModel.CreateMessagePost009(ref post, person);
                    break;

                case 20:
                    MessagePostViewModel.CreateMessagePost010(ref post, person);
                    break;

                case 21:
                    VideoPostViewModel.CreateVideoPost001(ref post, person);
                    break;

                case 22:
                    VideoPostViewModel.CreateVideoPost002(ref post, person);
                    break;

                case 23:
                    VideoPostViewModel.CreateVideoPost003(ref post, person);
                    break;

                case 24:
                    VideoPostViewModel.CreateVideoPost004(ref post, person);
                    break;

                case 25:
                    VideoPostViewModel.CreateVideoPost005(ref post, person);
                    break;

                default:
                    break;
            }
            post.ShortCommentsVisibility = true;
            postId++;
            return post;
        }

        #endregion

        #endregion
    }
}

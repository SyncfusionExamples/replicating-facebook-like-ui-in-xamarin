using FB_Like_Sample.Interface;
using FB_Like_Sample.ViewModels;
using FB_Like_Sample.Views;
using FB_Like_Sample.Views.Templates;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FB_Like_Sample.Models
{
    public class Post : BaseModel
    {
        #region Fields

        private int id;
        private Person owner;
        private DateTime postedOn;
        private ObservableCollection<PostReaction> reactions;
        private ObservableCollection<PostComment> comments;
        private string message;
        private string picture;
        private string newCommentText;
        private string reactionText;
        private int reactionIndex;
        private FileMediaSource mediaSource;
        private PostType postType;
        private Command shareCommand;
        private Command addCommentCommand;
        private Command openPostCommand;
        private bool shortCommentsVisibility;
        private bool moreIconVisibility;

        #endregion

        #region Properties

        public int ID
        {
            get { return id; }
            set { SetProperty(ref id, value); }
        }

        public Person Owner
        {
            get { return owner; }
            set { SetProperty(ref owner, value); }
        }

        public DateTime PostedOn
        {
            get { return postedOn; }
            set { SetProperty(ref postedOn, value); }
        }

        public ObservableCollection<PostReaction> Reactions
        {
            get { return reactions; }
            set { SetProperty(ref reactions, value); }
        }

        public ObservableCollection<PostComment> Comments
        {
            get { return comments; }
            set 
            {
                SetProperty(ref comments, value);
                comments.CollectionChanged += Comments_CollectionChanged;
            }
        }

        public bool ShortCommentsVisibility
        {
            get { return shortCommentsVisibility; }
            set { SetProperty(ref shortCommentsVisibility, value); }
        }

        public string Message
        {
            get { return message; }
            set { SetProperty(ref message, value); }
        }

        public string Picture
        {
            get { return picture; }
            set { SetProperty(ref picture, value); }
        }

        public FileMediaSource MediaSource
        {
            get { return mediaSource; }
            set { SetProperty(ref mediaSource, value); }
        }

        public PostType PostType
        {
            get { return postType; }
            set { SetProperty(ref postType, value); }
        }

        public FBViewModel ViewModel { get; set; }

        public bool AllowReactionUpdate { get; set; }

        public string NewCommentText
        {
            get { return newCommentText; }
            set { SetProperty(ref newCommentText, value); }
        }

        public string ReactionText
        {
            get { return reactionText; }
            set { SetProperty(ref reactionText, value); }
        }       

        public int ReactionIndex
        {
            get { return reactionIndex; }
            set { SetProperty(ref reactionIndex, value); }
        }

        public Page MainPage
        {
            get
            {
                return Application.Current.MainPage;
            }
        }        

        public bool MoreIconVisibility
        {
            get { return moreIconVisibility; }
            set { SetProperty(ref moreIconVisibility, value); }
        }


        #endregion

        #region Commands

        /// <summary>
        /// Gets or sets the command that will be executed when clicked share.
        /// </summary>
        public Command ShareCommand
        {
            get
            {
                return this.shareCommand ?? (this.shareCommand = new Command(this.PostShare));
            }
        }

        /// <summary>
        /// Gets or sets the command that will be executed when clicked add comment.
        /// </summary>
        public Command AddCommentCommand
        {
            get
            {
                return this.addCommentCommand ?? (this.addCommentCommand = new Command(this.AddComment));
            }
        }

        public Command OpenPostCommand
        {
            get
            {
                return this.openPostCommand ?? (this.openPostCommand = new Command(this.OpenPost));
            }
        }

        #endregion

        #region Constructor

        public Post(FBViewModel fBViewModel)
        {
            ViewModel = fBViewModel;
            ReactionText = "Like";
            MoreIconVisibility = true;
        }

        #endregion

        #region Methods

        private void Comments_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (Comments.Count == 1)
            {
                ShortCommentsVisibility = true;
            }
        }

        private void AddComment(object selectedItem)
        {
            if (!string.IsNullOrEmpty(NewCommentText))
            {
                this.Comments.Add(new PostComment(ViewModel.LoggedInUser, NewCommentText, DateTime.Now));

                NewCommentText = string.Empty;

                IKeyboardHelper dependencyService = DependencyService.Get<IKeyboardHelper>();
                dependencyService?.HideKeyboard();
            }
        }

        private void PostShare(object selectedItem)
        {
            MainPage.DisplayAlert("Alert", "Shared this post in your timeline", "OK");
        }

        internal async void OpenPost(object selectedItem)
        {
            await Task.Delay(500);            
            await MainPage.Navigation.PushModalAsync(new NavigationPage(new FB_PostDetailPage(this)));
        }

        internal void ReactionUpdate(double value)
        {
            switch (value)
            {
                //Happy
                case 1:
                    var reaction = Reactions.Where(reaction1 => reaction1.ReactionType == ReactionType.Happy).FirstOrDefault();

                    if(reaction == null)
                    {
                        Reactions.Add(new PostReaction(this, ReactionType.Happy, 1));
                    }
                    else
                    {
                        (reaction as PostReaction).PostReactionCount++;
                    }
                    ReactionText = "Happy";

                    break;

                //Neutral
                case 2:
                    reaction = Reactions.Where(reaction1 => reaction1.ReactionType == ReactionType.Neutral).FirstOrDefault();

                    if (reaction == null)
                    {
                        Reactions.Add(new PostReaction(this, ReactionType.Neutral, 1));
                    }
                    else
                    {
                        (reaction as PostReaction).PostReactionCount++;
                    }
                    ReactionText = "Neutral";

                    break;

                //Wonder
                case 3:
                    reaction = Reactions.Where(reaction1 => reaction1.ReactionType == ReactionType.Wonder).FirstOrDefault();

                    if (reaction == null)
                    {
                        Reactions.Add(new PostReaction(this, ReactionType.Wonder, 1));
                    }
                    else
                    {
                        (reaction as PostReaction).PostReactionCount++;
                    }
                    ReactionText = "Wonder";

                    break;

                //Sad
                case 4:
                    reaction = Reactions.Where(reaction1 => reaction1.ReactionType == ReactionType.Sad).FirstOrDefault();

                    if (reaction == null)
                    {
                        Reactions.Add(new PostReaction(this, ReactionType.Sad, 1));
                    }
                    else
                    {
                        (reaction as PostReaction).PostReactionCount++;
                    }
                    ReactionText = "Sad";

                    break;

                //Angry
                case 5:
                    reaction = Reactions.Where(reaction1 => reaction1.ReactionType == ReactionType.Angry).FirstOrDefault();

                    if (reaction == null)
                    {
                        Reactions.Add(new PostReaction(this, ReactionType.Angry, 1));
                    }
                    else
                    {
                        (reaction as PostReaction).PostReactionCount++;
                    }
                    ReactionText = "Angry";

                    break;

                default:
                    break;
            }

            ReactionIndex = 0;
        }

        #endregion
    }

    public enum PostType
    {
        MessageOnly,
        Picture,
        Video
    }

    public enum ReactionType
    {
        Happy,
        Neutral,
        Wonder,
        Sad,
        Angry,
    }
}

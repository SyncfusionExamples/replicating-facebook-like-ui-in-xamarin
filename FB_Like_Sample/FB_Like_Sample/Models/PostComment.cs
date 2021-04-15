using System;
using Xamarin.Forms;

namespace FB_Like_Sample.Models
{
    public class PostComment : BaseModel
    {
        public Person User { get; set; }
        public string Comment { get; set; }
        public DateTime DateTime { get; set; }

        private string likeText;

        public string LikeText
        {
            get 
            {
                return likeText;
            }
            set 
            {
                SetProperty(ref likeText, value); 
            }
        }


        #region Command

        /// <summary>
        /// Gets or sets the command that is executed when the Log In button is clicked.
        /// </summary>
        public Command LikeCommand { get; set; }

        #endregion

        public PostComment(Person person, string comment, DateTime dateTime)
        {
            User = person;
            Comment = comment;
            DateTime = dateTime;

            this.LikeCommand = new Command(this.LikeClicked);

            LikeText = "Like";
        }

        #region Methods

        private void LikeClicked(object obj)
        {
            if(string.Equals(LikeText, "Like"))
            {
                LikeText = "Unlike";
            }
            else
            {
                LikeText = "Like";
            }
        }

        #endregion
    }
}
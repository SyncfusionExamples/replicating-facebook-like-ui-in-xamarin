using FB_Like_Sample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FB_Like_Sample.ViewModels
{
    internal class MessagePostViewModel
    {
        #region Message type posts

        public static void CreateMessagePost001(ref Post post, Person person)
        {
            post.PostType = PostType.MessageOnly;
            post.PostedOn = new DateTime(2019, 1, 6);
            post.Message = "Feeling Exited with my new Xamarin Application";
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post,ReactionType.Wonder, 2),
                new PostReaction(post, ReactionType.Happy, 5),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment(person.Friends[0], "All the best", post.PostedOn.AddDays(1)),
                new PostComment(person.Friends[1], "Congratz friend...",post.PostedOn.AddDays(2)),
                new PostComment(person.Friends[2], "Wow....Great.",post.PostedOn.AddDays(3)),
            };

        }

        public static void CreateMessagePost002(ref Post post, Person person)
        {
            post.PostType = PostType.MessageOnly;
            post.PostedOn = new DateTime(2019, 2, 7);
            post.Message = "She Gone. I’m Feeling So Lonely, Like A Ship In The Middle Of Sea; The Sky Is Weeping, The World Is Quiet";
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Sad, 10)
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "You are strong enough to face it all, even if it doesn't feel like it right now."
                , post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "There are some things you can only learn in a storm", post.PostedOn.AddDays(2)),
            };
        }

        public static void CreateMessagePost003(ref Post post, Person person)
        {
            post.PostType = PostType.MessageOnly;
            post.PostedOn = new DateTime(2019, 3, 8);
            post.Message = "Maybe if we start telling people their brain is an app, they’ll start to use it.";
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Wonder, 13),
                new PostReaction(post, ReactionType.Happy, 20),
                new PostReaction(post, ReactionType.Neutral, 10)
            };

            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Yeahhhhh. Definitely", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "Hilarious one....", post.PostedOn.AddDays(2)),
                new PostComment( person.Friends[2], "Nice.", post.PostedOn.AddDays(3)),
            };
        }

        public static void CreateMessagePost004(ref Post post, Person person)
        {
            post.PostType = PostType.MessageOnly;
            post.PostedOn = new DateTime(2019, 4, 9);
            post.Message = "Still we are seeing Child Labours in our street shops.";
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Angry, 10),
                new PostReaction(post, ReactionType.Neutral, 10),
                new PostReaction(post, ReactionType.Sad, 12)
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment(  person.Friends[0], "Alone we can do so little; together we can do so much", post.PostedOn.AddDays(1)),
                new PostComment(  person.Friends[1], "The rich cannot accumulate wealth without the co-operation of the poor in society.", post.PostedOn.AddDays(2)),
            };
        }

        public static void CreateMessagePost005(ref Post post, Person person)
        {
            post.PostType = PostType.MessageOnly;
            post.PostedOn = new DateTime(2019, 5, 10);
            post.Message = "Feeling fresh Morning with Cloudy rides";
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Happy, 7),
                new PostReaction(post, ReactionType.Neutral, 5),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Good Morning.", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "Enjoy every moment of this day.", post.PostedOn.AddDays(2))
            };
        }

        public static void CreateMessagePost006(ref Post post, Person person)
        {
            post.PostType = PostType.MessageOnly;
            post.PostedOn = new DateTime(2019, 6, 11);
            post.Message = "WeBINAR : Build PWAs with Blazor WebAssembly using Syncfusion [July 30, 10 AM]";
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Happy, 5),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Wow.. Great", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "I will attend this webinar to check how it works..", post.PostedOn.AddDays(2)),
            };
        }

        public static void CreateMessagePost007(ref Post post, Person person)
        {
            post.PostType = PostType.MessageOnly;
            post.PostedOn = new DateTime(2019, 7, 15);
            post.Message = "WeBINAR : User - Based Data Access in Bold BI Dashboards [July 323, 10 AM]";
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Happy, 5),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Wow.. Great", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "I will attend this webinar to check how it works..", post.PostedOn.AddDays(2)),
            };
        }

        public static void CreateMessagePost008(ref Post post, Person person)
        {
            post.PostType = PostType.MessageOnly;
            post.PostedOn = new DateTime(2019, 8, 18);
            post.Message = "2019 VOLUMNE 2 SP 1 RolledOut";
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Happy, 15),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Wow.. Great", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "Will check the updates...", post.PostedOn.AddDays(1)),
            };
        }

        public static void CreateMessagePost009(ref Post post, Person person)
        {
            post.PostType = PostType.MessageOnly;
            post.PostedOn = new DateTime(2019, 9, 19);
            post.Message = "WeBINAR : Creating a DashBoard in 5 Minutes or Less with Bold BI [October 23, 10 AM]";
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Happy, 5),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Wow.. Great", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "I will attend this webinar to check how it works..", post.PostedOn.AddDays(1)),
            };
        }

        public static void CreateMessagePost010(ref Post post, Person person)
        {
            post.PostType = PostType.MessageOnly;
            post.PostedOn = new DateTime(2019, 10, 25);
            post.Message = "Get instant support via our website chat [ Available 3AM - 9PM UTC ]";
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Happy, 5),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Wow.. Great", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "Nice to hear....", post.PostedOn.AddDays(1)),
            };
        }

        public static void AddNewPost(ref Post post, Person person, string message)
        {
            post.PostType = PostType.MessageOnly;
            post.PostedOn = DateTime.Now;
            post.Message = message;
            post.Reactions = new ObservableCollection<PostReaction>();
            post.Comments = new ObservableCollection<PostComment>();
        }

        #endregion
    }
}

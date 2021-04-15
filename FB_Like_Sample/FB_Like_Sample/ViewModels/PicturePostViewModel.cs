using FB_Like_Sample.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FB_Like_Sample.ViewModels
{
    internal class PicturePostViewModel
    {
        public static void CreatePicturePost001(ref Post post, Person person, string image)
        {
            post.PostType = PostType.Picture;
            post.Message = "Happy Holi to all my friends and relatives.";
            //Holi picture status
            post.Picture = image;
            post.PostedOn = new DateTime(2019, 3, 20);
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Wonder, 2),
                new PostReaction(post, ReactionType.Happy, 5),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Happy HOLI...", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "HAPPY HOLI......", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[2], "Happy Holi friend..", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[3], "Happy Holi to you and your family..", post.PostedOn.AddDays(1)),
            };

        }

        public static void CreatePicturePost002(ref Post post, Person person, string image)
        {
            post.PostType = PostType.Picture;
            post.Message = "Happy Diwali to all my friends and relatives.";
            //Diwali picture status
            post.Picture = image;
            post.PostedOn = new DateTime(2019, 10, 27);
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Wonder, 4),
                new PostReaction(post, ReactionType.Happy, 8),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Happy diwali...", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "HAPPY DIWALI......", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[2], "Happy Diwali friend..", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[3], "Happy Diwali to you and your family...", post.PostedOn.AddDays(1)),
            };
        }

        public static void CreatePicturePost003(ref Post post, Person person, string image)
        {
            post.PostType = PostType.Picture;
            post.Message = "Happy May Day to all my friends and relatives.";
            //May Day picture status
            post.Picture = image;
            post.PostedOn = new DateTime(2019, 5, 1);
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Wonder, 14),
                new PostReaction(post, ReactionType.Happy, 18),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Happy May Day...", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "HAPPY MAY DAY......", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[2], "Happy May Day friend..", post.PostedOn.AddDays(1)),
            };
        }

        public static void CreatePicturePost004(ref Post post, Person person, string image)
        {
            post.PostType = PostType.Picture;
            post.Message = "Today is Science Day. Thinks always innovative.";
            //Science Day picture status
            post.Picture = image;
            post.PostedOn = new DateTime(2019, 2, 28);
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Wonder, 10),
                new PostReaction(post, ReactionType.Happy, 6),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Everything is theoretically impossible, until it is done – Robert A. Heinlein.", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "Impossible only means that you haven’t found the solution yet.", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[2], "Science is not only a disciple of reason but also one of romance and passion.", post.PostedOn.AddDays(1)),
            };
        }

        public static void CreatePicturePost005(ref Post post, Person person, string image)
        {
            post.PostType = PostType.Picture;
            post.Message = "Today National Technology Day. Make yourself always update.";
            //National Technology Day picture status
            post.Picture = image;
            post.PostedOn = new DateTime(2019, 5, 11);
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Wonder, 12),
                new PostReaction(post, ReactionType.Happy, 16),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "The most technologically efficient machine that man has ever invented is the book.", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "Our technology forces us to live mythically.", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[2], "It’s supposed to be automatic, but actually you have to push this button.", post.PostedOn.AddDays(2)),
            };
        }

        public static void CreatePicturePost006(ref Post post, Person person, string image)
        {
            post.PostType = PostType.Picture;
            post.Message = "Happy Valentine's Day friends.";
            //Lovers Day picture status
            post.Picture = image;
            post.PostedOn = new DateTime(2019, 2, 14);
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Wonder, 13),
                new PostReaction(post, ReactionType.Happy, 12),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "There is only one happiness in life: to love and be loved.", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "Love is the greatest refreshment in life.", post.PostedOn.AddDays(2)),
                new PostComment( person.Friends[2], "Where there is love, there is life.", post.PostedOn.AddDays(3)),
            };
        }

        public static void CreatePicturePost007(ref Post post, Person person, string image)
        {
            post.PostType = PostType.Picture;
            post.Message = "Today No Smoking Day. Quit Smoking Live Long.";
            //No Smoking Day picture status
            post.Picture = image;
            post.PostedOn = new DateTime(2019, 3, 13);
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Wonder, 6),
                new PostReaction(post, ReactionType.Happy, 10),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Our strength grows out of our weakness.", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "Our life is in our hands, to make of it what we choose.", post.PostedOn.AddDays(2)),
                new PostComment( person.Friends[2], "A cigarette is the only consumer product which when used as directed kills its consumer.", post.PostedOn.AddDays(3)),
            };
        }

        public static void CreatePicturePost008(ref Post post, Person person, string image)
        {
            post.PostType = PostType.Picture;
            post.Message = "Today Health Day, be healthy always";
            //World Health Day picture status
            post.Picture = image;
            post.PostedOn = new DateTime(2019, 4, 7);
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Wonder, 11),
                new PostReaction(post, ReactionType.Happy, 20),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Health is the greatest gift, contentment the greatest wealth, faithfulness the best relationship.", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "A fit body, a calm mind, a house full of love. These things cannot be bought – they must be earned.", post.PostedOn.AddDays(2)),
                new PostComment( person.Friends[2], "Happiness is the highest form of health.", post.PostedOn.AddDays(3)),
            };
        }

        public static void CreatePicturePost009(ref Post post, Person person, string image)
        {
            post.PostType = PostType.Picture;
            post.Message = "Today World Earth Day. Plant trees, save water.";
            //World Earth Day picture status
            post.Picture = image;
            post.PostedOn = new DateTime(2019, 4, 22);
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Wonder, 11),
                new PostReaction(post, ReactionType.Happy, 20),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "I only feel angry when I see waste. When I see people throwing away things we could use — Mother Teresa", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[1], "One of the first conditions of happiness is that the link between man and nature shall not be broken.", post.PostedOn.AddDays(1)),
                new PostComment( person.Friends[2], "The environment is where we all meet; where we all have a mutual interest; it is the one thing all of us share.", post.PostedOn.AddDays(2)),
            };

        }

        public static void CreatePicturePost010(ref Post post, Person person, string image)
        {
            post.PostType = PostType.Picture;
            post.Message = "Happy Teachers Day";
            //World Teachers Day picture status
            post.Picture = image;
            post.PostedOn = new DateTime(2019, 9, 05);
            post.Reactions = new ObservableCollection<PostReaction>()
            {
                new PostReaction(post, ReactionType.Wonder, 10),
                new PostReaction(post, ReactionType.Happy, 25),
            };
            post.Comments = new ObservableCollection<PostComment>()
            {
                new PostComment( person.Friends[0], "Good teachers are the reason why ordinary students dream to do extraordinary things. Happy Teachers' Day", post.PostedOn.AddDays(1)),
                new PostComment(person.Friends[1], "Happy Teachers day", post.PostedOn.AddDays(2)),
            };
        }
    }
}

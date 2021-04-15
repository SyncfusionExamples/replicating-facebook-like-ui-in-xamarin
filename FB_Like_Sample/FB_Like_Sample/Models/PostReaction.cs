using System;
using Xamarin.Forms;

namespace FB_Like_Sample.Models
{
    public class PostReaction : BaseModel
    {
        public Post Post { get; set; }
        public ReactionType ReactionType { get; set; }

        private int reactionCount;

        public int PostReactionCount
        {
            get { return reactionCount; }
            set { SetProperty(ref reactionCount, value); }
        }


        public PostReaction(Post post, ReactionType type, int count)
        {
            Post = post;
            ReactionType = type;
            PostReactionCount = count;
        }
    }
}
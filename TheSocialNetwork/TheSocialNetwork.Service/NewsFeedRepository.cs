using System.Linq;
using TheSocialNetwork.Data.Entities;
using TheSocialNetwork.Data.Interface;
using TheSocialNetwork.Data;
using TheSocialNetwork.Service.Interface;

namespace TheSocialNetwork.Service
{
    public class NewsFeedRepository : INewsFeedRepository
    {
        private IDbContext _databaseContext { get; set; }

        public NewsFeedRepository()
        {
            _databaseContext = new DatabaseContext();
        }

        public NewsFeedRepository(IDbContext context)
        {
            _databaseContext = context;
        }
        public IQueryable<Post> GetPosts(long userId)
        {
            var friendsOfMine = _databaseContext.Posts.Where(x => x.User.FriendShips.Any(y => y.UserId == userId));
            var myFriends = _databaseContext.Posts.Where(x => x.User.MyFriends.Any(y => y.FriendId == userId));

            return friendsOfMine.Union(myFriends);
        }

        public IQueryable<Post> WriteNewPost(Post post)
        {
            if (post != null)
            {
                _databaseContext.Posts.Add(post);
                _databaseContext.SaveChanges();
            }

            return GetPosts(post.UserId);
        }
    }
}

using System.Linq;
using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Service.Interface
{
    public interface INewsFeedRepository
    {
        IQueryable<Post> GetPosts(long userId);
        IQueryable<Post> WriteNewPost(Post post);
    }
}

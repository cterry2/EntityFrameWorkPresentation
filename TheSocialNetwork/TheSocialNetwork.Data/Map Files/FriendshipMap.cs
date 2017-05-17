using System.Data.Entity.ModelConfiguration;
using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Data.Map_Files
{
    public class FriendshipMap : EntityTypeConfiguration<Friendship>
    {
        public FriendshipMap()
        {
            HasKey(t => new { t.UserId, t.FriendId });

            HasRequired(t => t.User).WithMany(t => t.FriendShips).HasForeignKey(t => t.UserId).WillCascadeOnDelete(false);
            HasRequired(t => t.Friend).WithMany(t => t.MyFriends).HasForeignKey(t => t.FriendId).WillCascadeOnDelete(false);
        }
    }
}

using System.Data.Entity.ModelConfiguration;
using TheSocialNetwork.Data.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheSocialNetwork.Data.Map_Files
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Username).HasMaxLength(30);

            HasMany(t => t.Posts).WithRequired(t => t.User).HasForeignKey(t => t.UserId);

            HasMany(t => t.FriendShips).WithRequired(t => t.User).HasForeignKey(t => t.UserId).WillCascadeOnDelete(false);
            HasMany(t => t.MyFriends).WithRequired(t => t.Friend).HasForeignKey(t => t.FriendId).WillCascadeOnDelete(false);            
        }
    }
}

using System.Data.Entity.ModelConfiguration;
using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Data.Map_Files
{
    public class PostMap : EntityTypeConfiguration<Post>
    {
        public PostMap()
        {
            HasKey(t => t.Id);
                        
            HasRequired(t => t.User).WithMany(t => t.Posts).HasForeignKey(t => t.UserId);
        }
    }
}

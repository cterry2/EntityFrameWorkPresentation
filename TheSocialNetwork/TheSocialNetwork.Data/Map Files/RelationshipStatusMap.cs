using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Data.Map_Files
{
    public class RelationshipStatusMap : EntityTypeConfiguration<RelationshipStatus>
    {
        public RelationshipStatusMap()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasMany(t => t.PersonalInformation).WithRequired(t => t.RelationshipStatus).HasForeignKey(t => t.RelationshipStatusId);
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Data.Map_Files
{
    public class PersonalInformationMap : EntityTypeConfiguration<PersonalInformation>
    {
        public PersonalInformationMap()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.FirstName).HasMaxLength(100);
            Property(t => t.LastName).HasMaxLength(200);

            HasRequired(t => t.RelationshipStatus).WithMany(t => t.PersonalInformation).HasForeignKey(t => t.RelationshipStatusId);
            HasMany(t => t.Addresses).WithRequired(t => t.PersonalInformation).HasForeignKey(t => t.PersonalInformationId);
            HasRequired(t => t.User).WithRequiredDependent(t => t.PersonalInformation);
        }
    }
}

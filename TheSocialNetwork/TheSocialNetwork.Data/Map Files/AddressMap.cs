using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Data.Map_Files
{
    public class AddressMap : EntityTypeConfiguration<Address>
    {
        public AddressMap()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.AddressLine).HasMaxLength(100);
            Property(t => t.AddressLineExtended).HasMaxLength(100);

            HasRequired(t => t.City).WithMany(t => t.Addresses).HasForeignKey(t => t.CityId);
            HasRequired(t => t.State).WithMany(t => t.Addresses).HasForeignKey(t => t.StateId);
            HasRequired(t => t.PersonalInformation).WithMany(t => t.Addresses).HasForeignKey(t => t.PersonalInformationId);
        }
    }
}

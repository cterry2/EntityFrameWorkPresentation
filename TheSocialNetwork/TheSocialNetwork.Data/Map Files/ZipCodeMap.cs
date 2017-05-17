using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Data.Map_Files
{
    public class ZipCodeMap : EntityTypeConfiguration<ZipCode>
    {
        public ZipCodeMap()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(t => t.City).WithMany(t => t.ZipCodes).HasForeignKey(t => t.CityId);
        }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Data.Map_Files
{
    public class CityMap : EntityTypeConfiguration<City>
    {
        public CityMap()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).HasMaxLength(150);

            HasMany(t => t.ZipCodes).WithRequired(t => t.City).HasForeignKey(t => t.CityId);
            
            HasMany(t => t.Addresses).WithRequired(t => t.City).HasForeignKey(t => t.CityId);
        }
    }
}

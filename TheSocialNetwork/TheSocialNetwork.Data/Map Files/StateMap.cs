using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Data.Map_Files
{
    public class StateMap : EntityTypeConfiguration<State>
    {
        public StateMap()
        {
            HasKey(t => t.Id);

            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            
            HasMany(t => t.Addresses).WithRequired(t => t.State).HasForeignKey(t => t.StateId);
        }
    }
}

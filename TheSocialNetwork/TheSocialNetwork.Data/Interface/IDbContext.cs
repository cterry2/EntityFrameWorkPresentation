using System.Data.Entity;
using TheSocialNetwork.Data.Entities;

namespace TheSocialNetwork.Data.Interface
{
    public interface IDbContext
    {
        IDbSet<User> Users { get; set; }
        IDbSet<Address> Addresses { get; set; }
        IDbSet<City> Cities { get; set; }
        IDbSet<State> States { get; set; }
        IDbSet<ZipCode> ZipCodes { get; set; }
        IDbSet<PersonalInformation> PersonalInformation { get; set; }
        IDbSet<RelationshipStatus> RelationshipStatuses { get; set; }
        IDbSet<Friendship> Friendships { get; set; }
        IDbSet<Post> Posts { get; set; }

        int SaveChanges();
    }
}

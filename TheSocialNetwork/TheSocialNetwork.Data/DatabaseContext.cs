using System;
using System.Data.Entity;
using System.Linq;
using TheSocialNetwork.Data.Entities;
using TheSocialNetwork.Data.Interface;
using TheSocialNetwork.Data.Map_Files;

namespace TheSocialNetwork.Data
{
    public class DatabaseContext : DbContext, IDbContext
    {
        public DatabaseContext() : base("TheSocialNetwork")
        {
            Configuration.LazyLoadingEnabled = true;            
        }

        // Use IDbSet instead of DbSet

        public IDbSet<User> Users { get; set; }
        public IDbSet<Address> Addresses { get; set; }
        public IDbSet<City> Cities { get; set; }
        public IDbSet<State> States { get; set; }
        public IDbSet<ZipCode> ZipCodes { get; set; }
        public IDbSet<PersonalInformation> PersonalInformation { get; set; }
        public IDbSet<RelationshipStatus> RelationshipStatuses { get; set; }
        public IDbSet<Friendship> Friendships { get; set; }
        public IDbSet<Post> Posts { get; set; }


        public override int SaveChanges()
        {
            // Allow for overrides before saving

            var selectedEntityList = ChangeTracker.Entries()
                                    .Where(x => x.Entity is ITimeStampEntity &&
                                    (x.State == EntityState.Added || x.State == EntityState.Modified));
            
            foreach (var entity in selectedEntityList)
            {
                ((ITimeStampEntity)entity.Entity).TimeStamp = DateTime.Now;                
            }

            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
            modelBuilder.Configurations.Add(new AddressMap());
            modelBuilder.Configurations.Add(new CityMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new ZipCodeMap());
            modelBuilder.Configurations.Add(new PersonalInformationMap());
            modelBuilder.Configurations.Add(new RelationshipStatusMap());
            modelBuilder.Configurations.Add(new FriendshipMap());
            modelBuilder.Configurations.Add(new PostMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}

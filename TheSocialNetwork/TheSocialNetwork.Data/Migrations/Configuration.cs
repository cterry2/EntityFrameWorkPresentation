namespace TheSocialNetwork.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TheSocialNetwork.Data.Entities;

    internal sealed class Configuration : DbMigrationsConfiguration<TheSocialNetwork.Data.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DatabaseContext context)
        {
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[RelationshipStatus] On ");
            //context.RelationshipStatuses.Add(new RelationshipStatus()
            //{
                
            //    Value = "Single"
            //});

            //context.RelationshipStatuses.Add(new RelationshipStatus()
            //{
                
            //    Value = "Its Complicated"
            //});
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[RelationshipStatus] Off ");

            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Users] On ");
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[PersonalInformations] On ");
            //context.Users.Add(new User()
            //{
                
            //    Username = "mainuser",                
            //});

            //context.PersonalInformation.Add(new PersonalInformation
            //{

            //    FirstName = "Barry",
            //    LastName = "Allen",
            //    BirthDate = new DateTime(1980, 6, 1),
            //    RelationshipStatusId = 1,
            //    SignificantOtherId = null,
            //});

            //context.Users.Add(new User()
            //{
                
            //    Username = "seconduser",
                
            //});

            //context.PersonalInformation.Add(new PersonalInformation
            //{

            //    FirstName = "Jane",
            //    LastName = "Foster",
            //    BirthDate = new DateTime(1980, 6, 1),
            //    RelationshipStatusId = 2,
            //    SignificantOtherId = null,
            //});

            //context.Users.Add(new User()
            //{
                
            //    Username = "thirduser",
                
            //});

            //context.PersonalInformation.Add(new PersonalInformation
            //{
            //    FirstName = "James",
            //    LastName = "Howlett",
            //    BirthDate = new DateTime(1980, 6, 1),
            //    RelationshipStatusId = 1,
            //    SignificantOtherId = null,
            //});


            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Users] Off ");
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[PersonalInformations] Off ");

            //context.Friendships.Add(new Friendship() { UserId = 1, FriendId = 2 });
            //context.Friendships.Add(new Friendship() { UserId = 1, FriendId = 3 });
            //context.Friendships.Add(new Friendship() { UserId = 3, FriendId = 2 });

            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Cities] On ");
            //context.Cities.Add(new City
            //{
                            
            //    Name = "Lincoln",                 
            //});
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Cities] Off ");


            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[States] On ");
            //context.States.Add(new State()
            //{
                
            //    Abbreviation = "NE",
            //    FullName = "Nebraska",

            //});
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[States] Off ");
            
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Addresses] On ");
            //context.Addresses.Add(new Address()
            //{
                
            //    AddressLine = "123 Your Way",
            //    CityId = 1,                
            //    PersonalInformationId = 1,
            //    ZipCode = 123456,
            //    StateId = 1,                
            //});
            
            //context.Addresses.Add(new Address()
            //{
                
            //    AddressLine = "124 Your Way",
            //    CityId = 1,
                
            //    PersonalInformationId = 2,
            //    ZipCode = 123456,
            //    StateId = 1,
            //});

            //context.Addresses.Add(new Address()
            //{
                
            //    AddressLine = "133 Your Way",
            //    CityId = 1,
                
            //    PersonalInformationId = 3,
            //    ZipCode = 123456,
            //    StateId = 1,
            //});
            //context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[Addresses] Off ");          


            ////context.SaveChanges();
        }
    }
}

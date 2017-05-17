namespace TheSocialNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        AddressLine = c.String(maxLength: 100),
                        AddressLineExtended = c.String(maxLength: 100),
                        CityId = c.Int(nullable: false),
                        ZipCode = c.Int(nullable: false),
                        StateId = c.Int(nullable: false),
                        PersonalInformationId = c.Long(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.PersonalInformations", t => t.PersonalInformationId, cascadeDelete: true)
                .ForeignKey("dbo.States", t => t.StateId, cascadeDelete: true)
                .Index(t => t.CityId)
                .Index(t => t.StateId)
                .Index(t => t.PersonalInformationId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 150),
                        StateId = c.Int(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.States", t => t.StateId)
                .Index(t => t.StateId);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        Abbreviation = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ZipCodes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PostalCode = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .Index(t => t.CityId);
            
            CreateTable(
                "dbo.PersonalInformations",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 100),
                        LastName = c.String(maxLength: 200),
                        BirthDate = c.DateTime(nullable: false),
                        RelationshipStatusId = c.Short(nullable: false),
                        SignificantOtherId = c.Long(nullable: false),
                        UserId = c.Long(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RelationshipStatus", t => t.RelationshipStatusId, cascadeDelete: true)
                .ForeignKey("dbo.PersonalInformations", t => t.SignificantOtherId)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id)
                .Index(t => t.RelationshipStatusId)
                .Index(t => t.SignificantOtherId);
            
            CreateTable(
                "dbo.RelationshipStatus",
                c => new
                    {
                        Id = c.Short(nullable: false, identity: true),
                        Value = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Username = c.String(maxLength: 30),
                        PersonalInformationId = c.Long(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Friendships",
                c => new
                    {
                        UserId = c.Long(nullable: false),
                        FriendId = c.Long(nullable: false),
                        Active = c.Boolean(nullable: false),
                        TimeStamp = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.UserId, t.FriendId })
                .ForeignKey("dbo.Users", t => t.FriendId)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.FriendId);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Content = c.String(),
                        Title = c.String(),
                        TimeStamp = c.DateTime(nullable: false),
                        UserId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Addresses", "StateId", "dbo.States");
            DropForeignKey("dbo.Addresses", "PersonalInformationId", "dbo.PersonalInformations");
            DropForeignKey("dbo.Posts", "UserId", "dbo.Users");
            DropForeignKey("dbo.PersonalInformations", "Id", "dbo.Users");
            DropForeignKey("dbo.Friendships", "UserId", "dbo.Users");
            DropForeignKey("dbo.Friendships", "FriendId", "dbo.Users");
            DropForeignKey("dbo.PersonalInformations", "SignificantOtherId", "dbo.PersonalInformations");
            DropForeignKey("dbo.PersonalInformations", "RelationshipStatusId", "dbo.RelationshipStatus");
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropForeignKey("dbo.ZipCodes", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Cities", "StateId", "dbo.States");
            DropIndex("dbo.Posts", new[] { "UserId" });
            DropIndex("dbo.Friendships", new[] { "FriendId" });
            DropIndex("dbo.Friendships", new[] { "UserId" });
            DropIndex("dbo.PersonalInformations", new[] { "SignificantOtherId" });
            DropIndex("dbo.PersonalInformations", new[] { "RelationshipStatusId" });
            DropIndex("dbo.PersonalInformations", new[] { "Id" });
            DropIndex("dbo.ZipCodes", new[] { "CityId" });
            DropIndex("dbo.Cities", new[] { "StateId" });
            DropIndex("dbo.Addresses", new[] { "PersonalInformationId" });
            DropIndex("dbo.Addresses", new[] { "StateId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Friendships");
            DropTable("dbo.Users");
            DropTable("dbo.RelationshipStatus");
            DropTable("dbo.PersonalInformations");
            DropTable("dbo.ZipCodes");
            DropTable("dbo.States");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}

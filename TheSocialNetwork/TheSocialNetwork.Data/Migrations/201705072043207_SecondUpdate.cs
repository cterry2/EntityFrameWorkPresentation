namespace TheSocialNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondUpdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "PersonalInformationId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "PersonalInformationId", c => c.Long(nullable: false));
        }
    }
}

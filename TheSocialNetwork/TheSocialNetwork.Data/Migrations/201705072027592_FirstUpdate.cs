namespace TheSocialNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstUpdate : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.PersonalInformations", new[] { "SignificantOtherId" });
            AlterColumn("dbo.PersonalInformations", "SignificantOtherId", c => c.Long());
            CreateIndex("dbo.PersonalInformations", "SignificantOtherId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.PersonalInformations", new[] { "SignificantOtherId" });
            AlterColumn("dbo.PersonalInformations", "SignificantOtherId", c => c.Long(nullable: false));
            CreateIndex("dbo.PersonalInformations", "SignificantOtherId");
        }
    }
}

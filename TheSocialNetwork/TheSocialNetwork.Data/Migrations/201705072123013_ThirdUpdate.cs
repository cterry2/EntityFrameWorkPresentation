namespace TheSocialNetwork.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ThirdUpdate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Cities", "StateId", "dbo.States");
            DropIndex("dbo.Cities", new[] { "StateId" });
            DropColumn("dbo.Cities", "StateId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cities", "StateId", c => c.Int(nullable: false));
            CreateIndex("dbo.Cities", "StateId");
            AddForeignKey("dbo.Cities", "StateId", "dbo.States", "Id");
        }
    }
}

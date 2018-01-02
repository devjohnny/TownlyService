namespace TownlyService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Event",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        From = c.DateTimeOffset(nullable: false, precision: 7),
                        To = c.DateTimeOffset(nullable: false, precision: 7),
                        Public = c.Boolean(nullable: false),
                        Moderated = c.Boolean(nullable: false),
                        Barcode = c.String(),
                        CreatedBy = c.String(nullable: false),
                        CreatedAtUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedAtUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        PublicEventId = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Question",
                c => new
                    {
                        QuestionId = c.Int(nullable: false, identity: true),
                        QuestionText = c.String(),
                        Moderated = c.Boolean(nullable: false),
                        CreatedBy = c.String(nullable: false),
                        CreatedAtUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        ModifiedAtUtc = c.DateTimeOffset(nullable: false, precision: 7),
                        EventId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.Event", t => t.EventId, cascadeDelete: true)
                .Index(t => t.EventId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Question", "EventId", "dbo.Event");
            DropIndex("dbo.Question", new[] { "EventId" });
            DropTable("dbo.Question");
            DropTable("dbo.Event");
        }
    }
}

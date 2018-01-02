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
                    Name = c.String(nullable: false, maxLength: 256),
                    EventId = c.Guid(nullable: false, identity: true, defaultValueSql: "newsequentialid()"),
                    Description = c.String(),
                    From = c.DateTimeOffset(nullable: false, precision: 7),
                    To = c.DateTimeOffset(nullable: false, precision: 7),
                    Public = c.Boolean(nullable: false),
                    Moderated = c.Boolean(nullable: false),
                    Barcode = c.String(),
                    CreatedBy = c.String(nullable: false),
                    CreatedAtUtc = c.DateTimeOffset(nullable: false, precision: 7),
                    ModifiedAtUtc = c.DateTimeOffset(nullable: false, precision: 7),
                })
                .PrimaryKey(t => t.Name);

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
                    Event_Name = c.String(maxLength: 256),
                })
                .PrimaryKey(t => t.QuestionId)
                .ForeignKey("dbo.Event", t => t.Event_Name)
                .Index(t => t.Event_Name);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Question", "Event_Name", "dbo.Event");
            DropIndex("dbo.Question", new[] { "Event_Name" });
            DropTable("dbo.Question");
            DropTable("dbo.Event");
        }
    }
}

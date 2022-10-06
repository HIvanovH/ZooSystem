namespace Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InititalCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Animals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Picture = c.Binary(),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.CategoryId);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        Description = c.String(),
                        TypeId = c.Int(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EventsTypes", t => t.TypeId, cascadeDelete: true)
                .Index(t => t.TypeId);
            
            CreateTable(
                "dbo.EventsTypes",
                c => new
                    {
                        TypeId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.TypeId);
            
            CreateTable(
                "dbo.TicketsTypes",
                c => new
                    {
                        TypeTicketId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.TypeTicketId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Role = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.UserOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdUser = c.Int(nullable: false),
                        IdTypeTicket = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TicketsTypes", t => t.IdTypeTicket, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.IdUser, cascadeDelete: true)
                .Index(t => t.IdUser)
                .Index(t => t.IdTypeTicket);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserOrders", "IdUser", "dbo.Users");
            DropForeignKey("dbo.UserOrders", "IdTypeTicket", "dbo.TicketsTypes");
            DropForeignKey("dbo.Events", "TypeId", "dbo.EventsTypes");
            DropForeignKey("dbo.Animals", "CategoryId", "dbo.Categories");
            DropIndex("dbo.UserOrders", new[] { "IdTypeTicket" });
            DropIndex("dbo.UserOrders", new[] { "IdUser" });
            DropIndex("dbo.Events", new[] { "TypeId" });
            DropIndex("dbo.Animals", new[] { "CategoryId" });
            DropTable("dbo.UserOrders");
            DropTable("dbo.Users");
            DropTable("dbo.TicketsTypes");
            DropTable("dbo.EventsTypes");
            DropTable("dbo.Events");
            DropTable("dbo.Categories");
            DropTable("dbo.Animals");
        }
    }
}

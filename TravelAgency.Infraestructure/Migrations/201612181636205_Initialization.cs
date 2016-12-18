namespace TravelAgency.Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initialization : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Insurances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExternalCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        SellerCode = c.String(),
                        CardNumber = c.String(),
                        PhoneNumber = c.String(storeType: "ntext"),
                        Adress = c.String(storeType: "ntext"),
                        Points = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Travels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Origen = c.String(nullable: false, storeType: "ntext"),
                        DepartureTime = c.DateTime(nullable: false),
                        Destination = c.String(nullable: false, storeType: "ntext"),
                        ReturnTime = c.DateTime(nullable: false),
                        Comments = c.String(nullable: false, storeType: "ntext"),
                        Favourite = c.Boolean(nullable: false),
                        Price = c.Double(nullable: false),
                        TravellerId = c.Int(nullable: false),
                        InsuranceId = c.Int(),
                        SellerId = c.Int(),
                        Traveller_Id = c.Int(),
                        Traveller_Id1 = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Insurances", t => t.InsuranceId)
                .ForeignKey("dbo.Users", t => t.SellerId)
                .ForeignKey("dbo.Users", t => t.TravellerId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.Traveller_Id)
                .ForeignKey("dbo.Users", t => t.Traveller_Id1)
                .Index(t => t.TravellerId)
                .Index(t => t.InsuranceId)
                .Index(t => t.SellerId)
                .Index(t => t.Traveller_Id)
                .Index(t => t.Traveller_Id1);
            
            CreateTable(
                "dbo.TravellerSellers",
                c => new
                    {
                        Traveller_Id = c.Int(nullable: false),
                        Seller_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Traveller_Id, t.Seller_Id })
                .ForeignKey("dbo.Users", t => t.Traveller_Id)
                .ForeignKey("dbo.Users", t => t.Seller_Id)
                .Index(t => t.Traveller_Id)
                .Index(t => t.Seller_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Travels", "Traveller_Id1", "dbo.Users");
            DropForeignKey("dbo.Travels", "Traveller_Id", "dbo.Users");
            DropForeignKey("dbo.Travels", "TravellerId", "dbo.Users");
            DropForeignKey("dbo.Travels", "SellerId", "dbo.Users");
            DropForeignKey("dbo.Travels", "InsuranceId", "dbo.Insurances");
            DropForeignKey("dbo.TravellerSellers", "Seller_Id", "dbo.Users");
            DropForeignKey("dbo.TravellerSellers", "Traveller_Id", "dbo.Users");
            DropIndex("dbo.TravellerSellers", new[] { "Seller_Id" });
            DropIndex("dbo.TravellerSellers", new[] { "Traveller_Id" });
            DropIndex("dbo.Travels", new[] { "Traveller_Id1" });
            DropIndex("dbo.Travels", new[] { "Traveller_Id" });
            DropIndex("dbo.Travels", new[] { "SellerId" });
            DropIndex("dbo.Travels", new[] { "InsuranceId" });
            DropIndex("dbo.Travels", new[] { "TravellerId" });
            DropTable("dbo.TravellerSellers");
            DropTable("dbo.Travels");
            DropTable("dbo.Users");
            DropTable("dbo.Insurances");
        }
    }
}

namespace TravelAgency.Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InheritestrategychangesandSeed : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Users", newName: "Seller");
            DropForeignKey("dbo.Travels", "TravellerId", "dbo.Users");
            DropForeignKey("dbo.TravellerSellers", "Traveller_Id", "dbo.Users");
            DropForeignKey("dbo.TravellerSellers", "Seller_Id", "dbo.Users");
            DropForeignKey("dbo.Travels", "SellerId", "dbo.Users");
            DropForeignKey("dbo.Travels", "Traveller_Id", "dbo.Users");
            DropForeignKey("dbo.Travels", "Traveller_Id1", "dbo.Users");
            DropPrimaryKey("dbo.Seller");
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Traveller",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        CardNumber = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false, storeType: "ntext"),
                        Adress = c.String(storeType: "ntext"),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.Id)
                .Index(t => t.Id);
            
            AlterColumn("dbo.Seller", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Seller", "SellerCode", c => c.String(nullable: false));
            AddPrimaryKey("dbo.Seller", "Id");
            CreateIndex("dbo.Seller", "Id");
            AddForeignKey("dbo.Seller", "Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Travels", "TravellerId", "dbo.Traveller", "Id");
            AddForeignKey("dbo.TravellerSellers", "Seller_Id", "dbo.Seller", "Id");
            AddForeignKey("dbo.Travels", "SellerId", "dbo.Seller", "Id");
            DropColumn("dbo.Seller", "FirstName");
            DropColumn("dbo.Seller", "Surname");
            DropColumn("dbo.Seller", "UserName");
            DropColumn("dbo.Seller", "Password");
            DropColumn("dbo.Seller", "CardNumber");
            DropColumn("dbo.Seller", "PhoneNumber");
            DropColumn("dbo.Seller", "Adress");
            DropColumn("dbo.Seller", "Points");
            DropColumn("dbo.Seller", "Discriminator");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Seller", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Seller", "Points", c => c.Int());
            AddColumn("dbo.Seller", "Adress", c => c.String(storeType: "ntext"));
            AddColumn("dbo.Seller", "PhoneNumber", c => c.String(storeType: "ntext"));
            AddColumn("dbo.Seller", "CardNumber", c => c.String());
            AddColumn("dbo.Seller", "Password", c => c.String(nullable: false));
            AddColumn("dbo.Seller", "UserName", c => c.String(nullable: false));
            AddColumn("dbo.Seller", "Surname", c => c.String(nullable: false));
            AddColumn("dbo.Seller", "FirstName", c => c.String(nullable: false));
            DropForeignKey("dbo.Travels", "SellerId", "dbo.Seller");
            DropForeignKey("dbo.TravellerSellers", "Seller_Id", "dbo.Seller");
            DropForeignKey("dbo.Travels", "TravellerId", "dbo.Traveller");
            DropForeignKey("dbo.Traveller", "Id", "dbo.Users");
            DropForeignKey("dbo.Seller", "Id", "dbo.Users");
            DropIndex("dbo.Traveller", new[] { "Id" });
            DropIndex("dbo.Seller", new[] { "Id" });
            DropPrimaryKey("dbo.Seller");
            AlterColumn("dbo.Seller", "SellerCode", c => c.String());
            AlterColumn("dbo.Seller", "Id", c => c.Int(nullable: false, identity: true));
            DropTable("dbo.Traveller");
            DropTable("dbo.Users");
            AddPrimaryKey("dbo.Seller", "Id");
            AddForeignKey("dbo.Travels", "Traveller_Id1", "dbo.Users", "Id");
            AddForeignKey("dbo.Travels", "Traveller_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Travels", "SellerId", "dbo.Users", "Id");
            AddForeignKey("dbo.TravellerSellers", "Seller_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.TravellerSellers", "Traveller_Id", "dbo.Users", "Id");
            AddForeignKey("dbo.Travels", "TravellerId", "dbo.Users", "Id", cascadeDelete: true);
            RenameTable(name: "dbo.Seller", newName: "Users");
        }
    }
}

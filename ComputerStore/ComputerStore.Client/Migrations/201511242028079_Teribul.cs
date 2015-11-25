namespace ComputerStore.Client.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teribul : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "FullName", c => c.String());
            AddColumn("dbo.AspNetUsers", "TransportName", c => c.String());
            AddColumn("dbo.AspNetUsers", "TransportCountry", c => c.String());
            AddColumn("dbo.AspNetUsers", "TransportIr", c => c.String());
            AddColumn("dbo.AspNetUsers", "TransportCity", c => c.String());
            AddColumn("dbo.AspNetUsers", "TransportStreet", c => c.String());
            AddColumn("dbo.AspNetUsers", "BillName", c => c.String());
            AddColumn("dbo.AspNetUsers", "BillCountry", c => c.String());
            AddColumn("dbo.AspNetUsers", "BillIr", c => c.String());
            AddColumn("dbo.AspNetUsers", "BillCity", c => c.String());
            AddColumn("dbo.AspNetUsers", "BillStreet", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "BillStreet");
            DropColumn("dbo.AspNetUsers", "BillCity");
            DropColumn("dbo.AspNetUsers", "BillIr");
            DropColumn("dbo.AspNetUsers", "BillCountry");
            DropColumn("dbo.AspNetUsers", "BillName");
            DropColumn("dbo.AspNetUsers", "TransportStreet");
            DropColumn("dbo.AspNetUsers", "TransportCity");
            DropColumn("dbo.AspNetUsers", "TransportIr");
            DropColumn("dbo.AspNetUsers", "TransportCountry");
            DropColumn("dbo.AspNetUsers", "TransportName");
            DropColumn("dbo.AspNetUsers", "FullName");
        }
    }
}

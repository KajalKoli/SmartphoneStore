namespace SmartphoneShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SmartphoneFeaturePropChange : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SmartphoneFeature");
            AlterColumn("dbo.SmartphoneFeature", "MobileId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.SmartphoneFeature", "MobileId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SmartphoneFeature");
            AlterColumn("dbo.SmartphoneFeature", "MobileId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.SmartphoneFeature", "MobileId");
        }
    }
}

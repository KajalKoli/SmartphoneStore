namespace SmartphoneShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakeAllPropSmartphoneRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SmartphoneFeature", "Brand", c => c.String(nullable: false));
            AlterColumn("dbo.SmartphoneFeature", "Model", c => c.String(nullable: false));
            AlterColumn("dbo.SmartphoneFeature", "OS", c => c.String(nullable: false));
            AlterColumn("dbo.SmartphoneFeature", "Sim", c => c.String(nullable: false));
            AlterColumn("dbo.SmartphoneFeature", "Sensor", c => c.String(nullable: false));
            AlterColumn("dbo.SmartphoneFeature", "Color", c => c.String(nullable: false));
            AlterColumn("dbo.SmartphoneFeature", "Image", c => c.String(nullable: false, maxLength: 1024));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SmartphoneFeature", "Image", c => c.String(maxLength: 1024));
            AlterColumn("dbo.SmartphoneFeature", "Color", c => c.String());
            AlterColumn("dbo.SmartphoneFeature", "Sensor", c => c.String());
            AlterColumn("dbo.SmartphoneFeature", "Sim", c => c.String());
            AlterColumn("dbo.SmartphoneFeature", "OS", c => c.String());
            AlterColumn("dbo.SmartphoneFeature", "Model", c => c.String());
            AlterColumn("dbo.SmartphoneFeature", "Brand", c => c.String());
        }
    }
}

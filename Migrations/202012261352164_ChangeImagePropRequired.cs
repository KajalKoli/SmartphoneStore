namespace SmartphoneShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeImagePropRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SmartphoneFeature", "Image", c => c.String(nullable: false, maxLength: 2048));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SmartphoneFeature", "Image", c => c.String(maxLength: 1024));
        }
    }
}

namespace SmartphoneShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddHttpPostedFileImgProp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.SmartphoneFeature", "Image", c => c.String(maxLength: 1024));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SmartphoneFeature", "Image", c => c.String(nullable: false, maxLength: 1024));
        }
    }
}

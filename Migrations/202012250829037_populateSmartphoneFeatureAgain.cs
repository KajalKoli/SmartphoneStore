namespace SmartphoneShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateSmartphoneFeatureAgain : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[SmartphoneFeature] ([MobileId], [Brand], [Model], [Rating], [Price], [ScreenSize], [RAM], [InternalStorage], [FrontCamera], [RearCamera], [OS], [Sim], [Sensor], [BatteryCapacity], [Color], [Image]) VALUES (N'1', N'SAMSUNG', N'SAMSUNG GALAXY M01', 4.1, 8399, 15.75, 3, 32, 8, 13, N'Android Pie 9 ', N'Dual', N'No', 4000, N'Light Blue', N'~\Content\Image\SMM01.jpeg')
INSERT INTO [dbo].[SmartphoneFeature] ([MobileId], [Brand], [Model], [Rating], [Price], [ScreenSize], [RAM], [InternalStorage], [FrontCamera], [RearCamera], [OS], [Sim], [Sensor], [BatteryCapacity], [Color], [Image]) VALUES (N'2', N'SAMSUNG', N'SAMSUNG  GALAXY A10', 4.3, 7990, 15.75, 2, 32, 8, 13, N'Android Pie 9', N'Dual', N'No', 4000, N'Blue', N'~\Content\Image\SMGA10.jpg')
INSERT INTO [dbo].[SmartphoneFeature] ([MobileId], [Brand], [Model], [Rating], [Price], [ScreenSize], [RAM], [InternalStorage], [FrontCamera], [RearCamera], [OS], [Sim], [Sensor], [BatteryCapacity], [Color], [Image]) VALUES (N'3', N'MI', N'MI Note 9', 4.5, 7009, 16.59, 4, 64, 13, 48, N'MiUi11', N'Dual', N'Fingerprint', 5020, N'Aurora Blue', N'~\Content\Image\MINOTE9.jpg')
INSERT INTO [dbo].[SmartphoneFeature] ([MobileId], [Brand], [Model], [Rating], [Price], [ScreenSize], [RAM], [InternalStorage], [FrontCamera], [RearCamera], [OS], [Sim], [Sensor], [BatteryCapacity], [Color], [Image]) VALUES (N'4', N'MI', N'MI K20', 4.5, 24999, 16.23, 6, 128, 20, 48, N'MiUi11', N'Dual', N'Fingerprint', 4000, N'Horizon Red', N'~\Content\Image\MIK20.jpg')
INSERT INTO [dbo].[SmartphoneFeature] ([MobileId], [Brand], [Model], [Rating], [Price], [ScreenSize], [RAM], [InternalStorage], [FrontCamera], [RearCamera], [OS], [Sim], [Sensor], [BatteryCapacity], [Color], [Image]) VALUES (N'5', N'MI', N'MI 8A', 4.8, 8940, 15.8, 2, 32, 8, 13, N'Android Pie 9', N'Dual', N'Fingerprint', 5000, N'Sea Blue', N'~\Content\Image\A8.jpg')
INSERT INTO [dbo].[SmartphoneFeature] ([MobileId], [Brand], [Model], [Rating], [Price], [ScreenSize], [RAM], [InternalStorage], [FrontCamera], [RearCamera], [OS], [Sim], [Sensor], [BatteryCapacity], [Color], [Image]) VALUES (N'6', N'Apple', N'iphone XR', 4.6, 47500, 15.5, 4, 64, 7, 12, N'iOS', N'Single', N'Face ID', 5000, N'Black', N'~\Content\Image\XR.jpg')
INSERT INTO [dbo].[SmartphoneFeature] ([MobileId], [Brand], [Model], [Rating], [Price], [ScreenSize], [RAM], [InternalStorage], [FrontCamera], [RearCamera], [OS], [Sim], [Sensor], [BatteryCapacity], [Color], [Image]) VALUES (N'7', N'Apple', N'iPhone SE', 4.5, 37900, 11.94, 4, 64, 7, 12, N'iOS', N'Single', N'Face ID', 5000, N'Red', N'~\Content\Image\SE.jpg')
INSERT INTO [dbo].[SmartphoneFeature] ([MobileId], [Brand], [Model], [Rating], [Price], [ScreenSize], [RAM], [InternalStorage], [FrontCamera], [RearCamera], [OS], [Sim], [Sensor], [BatteryCapacity], [Color], [Image]) VALUES (N'8', N'Oppo', N'Oppo Reno 3 Pro', 4.5, 27990, 16.26, 8, 128, 32, 32, N'Android Pie 9', N'Dual', N'Fingerprint', 4025, N'Midnight Black', N'~\Content\Image\Reno.jpg')
INSERT INTO [dbo].[SmartphoneFeature] ([MobileId], [Brand], [Model], [Rating], [Price], [ScreenSize], [RAM], [InternalStorage], [FrontCamera], [RearCamera], [OS], [Sim], [Sensor], [BatteryCapacity], [Color], [Image]) VALUES (N'9', N'Oppo', N'Oppo Find X', 4.6, 60990, 16.26, 8, 256, 25, 36, N'Android Pie 9', N'Dual', N'Fingerprint', 3730, N'Bordeaux Red', N'~\Content\Image\FindX.jpeg')
");
        }
        
        public override void Down()
        {
        }
    }
}

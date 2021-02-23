namespace SmartphoneShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateASPNetUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0a7062e5-855e-4ca4-8ea5-b77c1308a1a6', N'kajalkolitest@gmail.com', 0, N'AHIsL8uQCIQ1L/aKzsCyxg9tBR08bidzy8dEDsoaAqjRz3PNZ6bJ2yT/OzoZ+ygPIQ==', N'e0a7bece-1d9a-4d18-98f3-1a43e50107b4', NULL, 0, 0, NULL, 1, 0, N'kajalkolitest@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'265dc6c8-07b4-45e3-87f8-e5f2512df162', N'aryastarktherealstark@gmail.com', 0, NULL, N'c6040eeb-3bc0-498d-b5cb-2dc6c1c8edec', NULL, 0, 0, NULL, 1, 0, N'aryastarktherealstark@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7d0f4b50-06d9-4648-8076-f03dded7fc7b', N'abc@gmail.com', 0, N'APTuSVhZHry9XLO9mato+7xO9HVLYWDJLdy4ovYHwbSBSu+t+GAGiuihN4OO70j0tQ==', N'62a6428c-be28-4f21-a637-ba360d758bdd', NULL, 0, 0, NULL, 1, 0, N'abc@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7dd4310f-874f-4169-a6ec-001580f7b00a', N'KKK@GMAIL.COM', 0, N'ALRCBrDYTKJNZtMrkpB6A4+y7ZFrTlhIBB6sL/F+xNCXUMCvDgXvjSXCeeujsVfHBw==', N'139aa3d6-9ef1-4805-8380-2a0c31da3afc', NULL, 0, 0, NULL, 1, 0, N'KKK@GMAIL.COM')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'90fb8127-497f-4a0c-a80f-b901817a0bb7', N'kajalkoli20@gmail.com', 0, N'AKk4FLwkuuSYTGjqSo7HuusEgztV7EoDf36upZ1BsgxzP3LY5LkdlAsnIVt8Z+yO1Q==', N'3b673f95-920b-4932-a1d3-9e8bfff0d15e', NULL, 0, 0, NULL, 1, 0, N'kajalkoli20@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fecbe0d5-1d8b-4cfd-ae7d-f5c629e99b02', N'random@gmail.com', 0, N'AKbJ+Ko4LsA4DcMzS8xAHzg/0CVcdRfJ9z8xVML+YmJ5Yot6UtGw/Tr8oqHvvclGwg==', N'500beef6-4c59-4ac8-adc8-86c25101b7e2', NULL, 0, 0, NULL, 1, 0, N'random@gmail.com')
");
        }
        
        public override void Down()
        {
        }
    }
}

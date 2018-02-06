namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b91093a3-164e-40b3-8e07-1fd6e5ce5f8a', N'guest@guest.com', 0, N'AF4LCPKa6aHQiRS6rulBitqcFPHpmc0mDZZQCkMIvoCK3RiFEguqDsYTyr6lit4dtQ==', N'357ab1eb-4020-4156-89e2-770dbef1cedb', NULL, 0, 0, NULL, 1, 0, N'guest@guest.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd655be54-5cc0-4bce-ba6b-701513a6e5ef', N'admin@admin.com', 0, N'AD+dEI4P9TCKAESKp8CsbVUdfh7LlumMk+K14MCxro/zYW/g+Wr2PlT4QttVHqFovA==', N'ff7340e6-f841-4088-b1f1-64d6517ad395', NULL, 0, 0, NULL, 1, 0, N'admin@admin.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'0fb301ce-e3c2-4d0b-a983-95e523251373', N'CanManageMovies')

                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd655be54-5cc0-4bce-ba6b-701513a6e5ef', N'0fb301ce-e3c2-4d0b-a983-95e523251373')

            ");
        }
        
        public override void Down()
        {
        }
    }
}

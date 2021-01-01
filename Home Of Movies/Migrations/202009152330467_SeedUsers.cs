namespace Home_Of_Movies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
             INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'be2d5961-a415-4d9a-8163-85514d0b9b20', N'admin@gmail.com', 0, N'APrkSyIZWndmtGdAjy/iI5y7F09VzzGjSkBEggLpXTynnDur5pUQ53bApl0LX6/kWQ==', N'b1a46aa3-fb95-4aa4-b0c6-3b030291ed57', NULL, 0, 0, NULL, 1, 0, N'admin@gmail.com')
             INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'e7dcfc40-8d9e-4ce3-a0d8-2e23e1f6ca43', N'guest@gmail.com', 0, N'AEic06XSQIZlq/NwdP8qbdGPDZMCwFLp7VKlDDdboR6fhSV3FvM9QKEUoVPsCYOqGA==', N'3c936e66-e5a9-4bf7-ad08-42d6cf78decb', NULL, 0, 0, NULL, 1, 0, N'guest@gmail.com')

             INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5efecb8f-55e3-4397-982e-c435f61091b6', N'CanManageMovies')
             INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'be2d5961-a415-4d9a-8163-85514d0b9b20', N'5efecb8f-55e3-4397-982e-c435f61091b6')

                ");
        }
        
        public override void Down()
        {
        }
    }
}

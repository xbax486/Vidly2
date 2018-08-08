namespace Vidly2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(
            @"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'08f238af-5079-464f-b7cc-d32217f08f7e', N'admin@vidly.com', 0, N'APemd4afbjzum5jVHZSfhTyJSx0j6EoMzCBZ9GpqM+iRlE2Dx6vfM5oAm7qmMAS5Lw==', N'8c49c8c8-4da5-4d14-bc96-6030f92d4144', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a80f27f6-a10a-4ac9-8c40-2d67d4aa6659', N'guest@vidly.com', 0, N'AJV8es7KXPE4DDc1LWf8bDzdCFxWsjBIHx2u0jatyki5SbFvPrCiUt959M4F+1hCag==', N'3bae7dab-e82f-4efe-9b20-6558a4ddde51', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7e48c8e7-b113-414c-b338-4e079c5ee71e', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'08f238af-5079-464f-b7cc-d32217f08f7e', N'7e48c8e7-b113-414c-b338-4e079c5ee71e')
            ");
        }
        
        public override void Down()
        {
        }
    }
}

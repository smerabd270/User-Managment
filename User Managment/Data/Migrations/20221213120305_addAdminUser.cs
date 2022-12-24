using Microsoft.EntityFrameworkCore.Migrations;

namespace User_Managment.Data.Migrations
{
    public partial class addAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [LastName], [ProfilePicutre]) VALUES (N'17a8fba4-d423-44fa-8ba3-1e7175ba0bf9', N'Admin', N'Admin', N'Admin@gmail.com', N'Admin@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEBSWGZt0Cd01eh34o1aZ9r/nQmgfRS7Bqr58KcOVCrqvSLtdEoMgq+ubpI2kKhHc/A==', N'LZK6IVBUSQIQWDE7I5T52UG5A3O5HDD5', N'ce01b82e-ac93-4c90-83a3-46045613b749', N'+963969776424', 0, 0, NULL, 1, 0, N'Amer', N'abd alrazak',NULL)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[Users] WHERE ID= '17a8fba4-d423-44fa-8ba3-1e7175ba0bf9'");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace User_Managment.Data.Migrations
{
    public partial class AssignAdminUserToRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [security].[UserRoles] (UserId,RoleId) SELECT  '17a8fba4-d423-44fa-8ba3-1e7175ba0bf9',Id from [security].[Roles]");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [security].[UserRoles] WHERE UserId ='17a8fba4-d423-44fa-8ba3-1e7175ba0bf9'");

        }
    }
}

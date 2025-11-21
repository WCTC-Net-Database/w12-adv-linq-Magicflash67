using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleRpgEntities.Migrations
{
    public partial class SeedItems : BaseMigration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            RunSql(migrationBuilder);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            RunSqlRollback(migrationBuilder);
        }
    }
}

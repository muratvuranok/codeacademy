#nullable disable
namespace WebApiSample.Migrations;
public partial class initialize : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder) { }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DropTable(
            name: "Categories");
    }
}

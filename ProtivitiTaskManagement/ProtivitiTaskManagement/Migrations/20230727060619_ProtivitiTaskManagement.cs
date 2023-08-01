using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProtivitiTaskManagement.Migrations
{
    public partial class ProtivitiTaskManagement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "varchar(100)", nullable: false),
                    CustomerMiddleName = table.Column<string>(type: "varchar(100)", nullable: true),
                    CustomerLastName = table.Column<string>(type: "varchar(100)", nullable: false),
                    CustomerDescription = table.Column<string>(type: "varchar(250)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskTitle = table.Column<string>(type: "varchar(100)", nullable: false),
                    TaskType = table.Column<string>(type: "varchar(100)", nullable: false),
                    TaskDescription = table.Column<string>(type: "varchar(250)", nullable: true),
                    TaskAssignee = table.Column<string>(type: "varchar(100)", nullable: false),
                    TaskCounty = table.Column<string>(type: "varchar(100)", nullable: false),
                    TaskCustomer = table.Column<string>(type: "varchar(100)", nullable: false),
                    TaskStatus = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(type: "varchar(100)", nullable: false),
                    UserMiddleName = table.Column<string>(type: "varchar(100)", nullable: true),
                    UserLastName = table.Column<string>(type: "varchar(100)", nullable: false),
                    UserPassword = table.Column<string>(type: "varchar(100)", nullable: false),
                    UserRole = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

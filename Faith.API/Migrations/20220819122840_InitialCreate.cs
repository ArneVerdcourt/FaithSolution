using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Faith.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Begeleiders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Begeleiders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jongeren",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BegeleiderId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jongeren", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JongereId = table.Column<int>(type: "int", nullable: false),
                    TimeStamp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reacties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reacties", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Begeleiders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Arne Verdcourt" },
                    { 2, "Tim Verdcourt" }
                });

            migrationBuilder.InsertData(
                table: "Jongeren",
                columns: new[] { "Id", "BegeleiderId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "John Doe" },
                    { 2, 1, "John Doe the second" },
                    { 3, 1, "John Doe the third" },
                    { 4, 1, "John Doe the fourth" },
                    { 5, 2, "Jane Doe" },
                    { 6, 2, "Jane Doe the second" },
                    { 7, 2, "Jane Doe the third" },
                    { 8, 2, "Jane Doe the fourth" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "ImageURL", "JongereId", "TimeStamp" },
                values: new object[,]
                {
                    { 1, "", 1, new DateTime(2022, 8, 19, 14, 28, 40, 708, DateTimeKind.Local).AddTicks(9343) },
                    { 2, "", 1, new DateTime(2022, 8, 19, 14, 28, 40, 708, DateTimeKind.Local).AddTicks(9395) },
                    { 3, "", 2, new DateTime(2022, 8, 19, 14, 28, 40, 708, DateTimeKind.Local).AddTicks(9402) },
                    { 4, "", 3, new DateTime(2022, 8, 19, 14, 28, 40, 708, DateTimeKind.Local).AddTicks(9408) },
                    { 5, "", 4, new DateTime(2022, 8, 19, 14, 28, 40, 708, DateTimeKind.Local).AddTicks(9414) },
                    { 6, "", 4, new DateTime(2022, 8, 19, 14, 28, 40, 708, DateTimeKind.Local).AddTicks(9421) },
                    { 7, "", 5, new DateTime(2022, 8, 19, 14, 28, 40, 708, DateTimeKind.Local).AddTicks(9427) },
                    { 8, "", 6, new DateTime(2022, 8, 19, 14, 28, 40, 708, DateTimeKind.Local).AddTicks(9455) },
                    { 9, "", 7, new DateTime(2022, 8, 19, 14, 28, 40, 708, DateTimeKind.Local).AddTicks(9462) },
                    { 10, "", 8, new DateTime(2022, 8, 19, 14, 28, 40, 708, DateTimeKind.Local).AddTicks(9470) }
                });

            migrationBuilder.InsertData(
                table: "Reacties",
                columns: new[] { "Id", "Content", "PostId" },
                values: new object[,]
                {
                    { 1, "Testing 1", 1 },
                    { 2, "Testing 2", 2 },
                    { 3, "Testing 3", 2 },
                    { 4, "Testing 4", 4 },
                    { 5, "Testing 5", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Begeleiders");

            migrationBuilder.DropTable(
                name: "Jongeren");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Reacties");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiTesting.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pockemos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pockemos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Pockemos",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[] { 1, "Picachu equis", "picahu Mexicano", "https://pbs.twimg.com/media/Eio96N9WAAEHuvI.jpg" });

            migrationBuilder.InsertData(
                table: "Pockemos",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[] { 2, "Pelicano equis", "Pelicano Mexicano", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRZpaNtJffGe5VRveyp7akE-mPKOBelV5kkCQ&usqp=CAU" });

            migrationBuilder.InsertData(
                table: "Pockemos",
                columns: new[] { "Id", "Description", "Name", "Photo" },
                values: new object[] { 3, "Perro equis", "Perro Mexicano", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTqTX3pGP591zsndXnabjeEyBQ6L_6m7Frp7w&usqp=CAU" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pockemos");
        }
    }
}

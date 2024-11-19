using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PublisherData.Migrations
{
    /// <inheritdoc />
    public partial class TestNullableCoverId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Covers_CoverId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CoverId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "CoverId",
                table: "Books",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Books_CoverId",
                table: "Books",
                column: "CoverId",
                unique: true,
                filter: "[CoverId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Covers_CoverId",
                table: "Books",
                column: "CoverId",
                principalTable: "Covers",
                principalColumn: "CoverId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Covers_CoverId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CoverId",
                table: "Books");

            migrationBuilder.AlterColumn<int>(
                name: "CoverId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CoverId",
                table: "Books",
                column: "CoverId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Covers_CoverId",
                table: "Books",
                column: "CoverId",
                principalTable: "Covers",
                principalColumn: "CoverId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

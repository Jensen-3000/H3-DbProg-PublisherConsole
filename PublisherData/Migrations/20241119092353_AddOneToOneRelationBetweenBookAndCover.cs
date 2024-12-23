﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PublisherData.Migrations
{
    /// <inheritdoc />
    public partial class AddOneToOneRelationBetweenBookAndCover : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoverId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Covers_CoverId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CoverId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CoverId",
                table: "Books");
        }
    }
}

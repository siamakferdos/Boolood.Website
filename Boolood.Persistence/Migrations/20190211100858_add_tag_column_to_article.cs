using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boolood.Persistence.Migrations
{
    public partial class add_tag_column_to_article : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentId",
                schema: "Boolood",
                table: "Categories");

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentId",
                schema: "Boolood",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tags",
                schema: "Boolood",
                table: "Articles",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentId",
                schema: "Boolood",
                table: "Categories",
                column: "ParentId",
                principalSchema: "Boolood",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentId",
                schema: "Boolood",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Tags",
                schema: "Boolood",
                table: "Articles");

            migrationBuilder.AlterColumn<Guid>(
                name: "ParentId",
                schema: "Boolood",
                table: "Categories",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentId",
                schema: "Boolood",
                table: "Categories",
                column: "ParentId",
                principalSchema: "Boolood",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

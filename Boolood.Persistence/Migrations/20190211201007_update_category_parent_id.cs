using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Boolood.Persistence.Migrations
{
    public partial class update_category_parent_id : Migration
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentId",
                schema: "Boolood",
                table: "Categories",
                column: "ParentId",
                principalSchema: "Boolood",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

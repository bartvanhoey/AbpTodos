﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Todos.Migrations
{
    public partial class TodoAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppTodos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDone = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppTodos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppTodos");
        }
    }
}

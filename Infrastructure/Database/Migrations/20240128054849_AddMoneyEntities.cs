using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddMoneyEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IncomeExpenditureTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MoneyFlow = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeExpenditureTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomeExpenditureTypes_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncomeExpenditureTypes_AspNetUsers_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MoneyAccounts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneyAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MoneyAccounts_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_MoneyAccounts_AspNetUsers_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IncomeExpenditures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IncomeExpenditureTypeId = table.Column<long>(type: "bigint", nullable: true),
                    MoneyAccountId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    UpdatedUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomeExpenditures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IncomeExpenditures_AspNetUsers_CreatedUserId",
                        column: x => x.CreatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncomeExpenditures_AspNetUsers_UpdatedUserId",
                        column: x => x.UpdatedUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncomeExpenditures_IncomeExpenditureTypes_IncomeExpenditureTypeId",
                        column: x => x.IncomeExpenditureTypeId,
                        principalTable: "IncomeExpenditureTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_IncomeExpenditures_MoneyAccounts_MoneyAccountId",
                        column: x => x.MoneyAccountId,
                        principalTable: "MoneyAccounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_IncomeExpenditures_CreatedUserId",
                table: "IncomeExpenditures",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeExpenditures_IncomeExpenditureTypeId",
                table: "IncomeExpenditures",
                column: "IncomeExpenditureTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeExpenditures_MoneyAccountId",
                table: "IncomeExpenditures",
                column: "MoneyAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeExpenditures_UpdatedUserId",
                table: "IncomeExpenditures",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeExpenditureTypes_CreatedUserId",
                table: "IncomeExpenditureTypes",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_IncomeExpenditureTypes_UpdatedUserId",
                table: "IncomeExpenditureTypes",
                column: "UpdatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyAccounts_CreatedUserId",
                table: "MoneyAccounts",
                column: "CreatedUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MoneyAccounts_UpdatedUserId",
                table: "MoneyAccounts",
                column: "UpdatedUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IncomeExpenditures");

            migrationBuilder.DropTable(
                name: "IncomeExpenditureTypes");

            migrationBuilder.DropTable(
                name: "MoneyAccounts");
        }
    }
}

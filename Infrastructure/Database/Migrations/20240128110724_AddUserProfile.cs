using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddUserProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditures_AspNetUsers_CreatedUserId",
                table: "IncomeExpenditures");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditures_AspNetUsers_UpdatedUserId",
                table: "IncomeExpenditures");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditures_IncomeExpenditureTypes_IncomeExpenditureTypeId",
                table: "IncomeExpenditures");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditures_MoneyAccounts_MoneyAccountId",
                table: "IncomeExpenditures");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditureTypes_AspNetUsers_CreatedUserId",
                table: "IncomeExpenditureTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditureTypes_AspNetUsers_UpdatedUserId",
                table: "IncomeExpenditureTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_MoneyAccounts_AspNetUsers_CreatedUserId",
                table: "MoneyAccounts");

            migrationBuilder.DropForeignKey(
                name: "FK_MoneyAccounts_AspNetUsers_UpdatedUserId",
                table: "MoneyAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoneyAccounts",
                table: "MoneyAccounts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeExpenditureTypes",
                table: "IncomeExpenditureTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeExpenditures",
                table: "IncomeExpenditures");

            migrationBuilder.RenameTable(
                name: "MoneyAccounts",
                newName: "MoneyAccount");

            migrationBuilder.RenameTable(
                name: "IncomeExpenditureTypes",
                newName: "IncomeExpenditureType");

            migrationBuilder.RenameTable(
                name: "IncomeExpenditures",
                newName: "IncomeExpenditure");

            migrationBuilder.RenameIndex(
                name: "IX_MoneyAccounts_UpdatedUserId",
                table: "MoneyAccount",
                newName: "IX_MoneyAccount_UpdatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MoneyAccounts_CreatedUserId",
                table: "MoneyAccount",
                newName: "IX_MoneyAccount_CreatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditureTypes_UpdatedUserId",
                table: "IncomeExpenditureType",
                newName: "IX_IncomeExpenditureType_UpdatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditureTypes_CreatedUserId",
                table: "IncomeExpenditureType",
                newName: "IX_IncomeExpenditureType_CreatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditures_UpdatedUserId",
                table: "IncomeExpenditure",
                newName: "IX_IncomeExpenditure_UpdatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditures_MoneyAccountId",
                table: "IncomeExpenditure",
                newName: "IX_IncomeExpenditure_MoneyAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditures_IncomeExpenditureTypeId",
                table: "IncomeExpenditure",
                newName: "IX_IncomeExpenditure_IncomeExpenditureTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditures_CreatedUserId",
                table: "IncomeExpenditure",
                newName: "IX_IncomeExpenditure_CreatedUserId");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MiddleName",
                table: "AspNetUsers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoneyAccount",
                table: "MoneyAccount",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeExpenditureType",
                table: "IncomeExpenditureType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeExpenditure",
                table: "IncomeExpenditure",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditure_AspNetUsers_CreatedUserId",
                table: "IncomeExpenditure",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditure_AspNetUsers_UpdatedUserId",
                table: "IncomeExpenditure",
                column: "UpdatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditure_IncomeExpenditureType_IncomeExpenditureTypeId",
                table: "IncomeExpenditure",
                column: "IncomeExpenditureTypeId",
                principalTable: "IncomeExpenditureType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditure_MoneyAccount_MoneyAccountId",
                table: "IncomeExpenditure",
                column: "MoneyAccountId",
                principalTable: "MoneyAccount",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditureType_AspNetUsers_CreatedUserId",
                table: "IncomeExpenditureType",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditureType_AspNetUsers_UpdatedUserId",
                table: "IncomeExpenditureType",
                column: "UpdatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MoneyAccount_AspNetUsers_CreatedUserId",
                table: "MoneyAccount",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MoneyAccount_AspNetUsers_UpdatedUserId",
                table: "MoneyAccount",
                column: "UpdatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditure_AspNetUsers_CreatedUserId",
                table: "IncomeExpenditure");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditure_AspNetUsers_UpdatedUserId",
                table: "IncomeExpenditure");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditure_IncomeExpenditureType_IncomeExpenditureTypeId",
                table: "IncomeExpenditure");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditure_MoneyAccount_MoneyAccountId",
                table: "IncomeExpenditure");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditureType_AspNetUsers_CreatedUserId",
                table: "IncomeExpenditureType");

            migrationBuilder.DropForeignKey(
                name: "FK_IncomeExpenditureType_AspNetUsers_UpdatedUserId",
                table: "IncomeExpenditureType");

            migrationBuilder.DropForeignKey(
                name: "FK_MoneyAccount_AspNetUsers_CreatedUserId",
                table: "MoneyAccount");

            migrationBuilder.DropForeignKey(
                name: "FK_MoneyAccount_AspNetUsers_UpdatedUserId",
                table: "MoneyAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoneyAccount",
                table: "MoneyAccount");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeExpenditureType",
                table: "IncomeExpenditureType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IncomeExpenditure",
                table: "IncomeExpenditure");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "MiddleName",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "MoneyAccount",
                newName: "MoneyAccounts");

            migrationBuilder.RenameTable(
                name: "IncomeExpenditureType",
                newName: "IncomeExpenditureTypes");

            migrationBuilder.RenameTable(
                name: "IncomeExpenditure",
                newName: "IncomeExpenditures");

            migrationBuilder.RenameIndex(
                name: "IX_MoneyAccount_UpdatedUserId",
                table: "MoneyAccounts",
                newName: "IX_MoneyAccounts_UpdatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_MoneyAccount_CreatedUserId",
                table: "MoneyAccounts",
                newName: "IX_MoneyAccounts_CreatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditureType_UpdatedUserId",
                table: "IncomeExpenditureTypes",
                newName: "IX_IncomeExpenditureTypes_UpdatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditureType_CreatedUserId",
                table: "IncomeExpenditureTypes",
                newName: "IX_IncomeExpenditureTypes_CreatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditure_UpdatedUserId",
                table: "IncomeExpenditures",
                newName: "IX_IncomeExpenditures_UpdatedUserId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditure_MoneyAccountId",
                table: "IncomeExpenditures",
                newName: "IX_IncomeExpenditures_MoneyAccountId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditure_IncomeExpenditureTypeId",
                table: "IncomeExpenditures",
                newName: "IX_IncomeExpenditures_IncomeExpenditureTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_IncomeExpenditure_CreatedUserId",
                table: "IncomeExpenditures",
                newName: "IX_IncomeExpenditures_CreatedUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoneyAccounts",
                table: "MoneyAccounts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeExpenditureTypes",
                table: "IncomeExpenditureTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IncomeExpenditures",
                table: "IncomeExpenditures",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditures_AspNetUsers_CreatedUserId",
                table: "IncomeExpenditures",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditures_AspNetUsers_UpdatedUserId",
                table: "IncomeExpenditures",
                column: "UpdatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditures_IncomeExpenditureTypes_IncomeExpenditureTypeId",
                table: "IncomeExpenditures",
                column: "IncomeExpenditureTypeId",
                principalTable: "IncomeExpenditureTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditures_MoneyAccounts_MoneyAccountId",
                table: "IncomeExpenditures",
                column: "MoneyAccountId",
                principalTable: "MoneyAccounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditureTypes_AspNetUsers_CreatedUserId",
                table: "IncomeExpenditureTypes",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_IncomeExpenditureTypes_AspNetUsers_UpdatedUserId",
                table: "IncomeExpenditureTypes",
                column: "UpdatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MoneyAccounts_AspNetUsers_CreatedUserId",
                table: "MoneyAccounts",
                column: "CreatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MoneyAccounts_AspNetUsers_UpdatedUserId",
                table: "MoneyAccounts",
                column: "UpdatedUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}

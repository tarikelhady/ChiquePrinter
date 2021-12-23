using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChiquePrinter.Infrastructure.Migrations
{
    public partial class intialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Banks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BankScemaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookLength = table.Column<int>(type: "int", nullable: false),
                    No = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Banks_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Chiqueaddresss",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    No = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chiqueaddresss", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chiqueaddresss_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    No = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Currencies_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "payees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorzedPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorzedPersonPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorzedPersonMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorzedPersonEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorzedPersonJob = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    authorizationImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payees_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "statuses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    No = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_statuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_statuses_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BankBooks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartChiqueNo = table.Column<int>(type: "int", nullable: false),
                    EndChiqueNo = table.Column<int>(type: "int", nullable: false),
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    No = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankBooks_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankBooks_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BankScemas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    DateFormat = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FontName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FontIsBold = table.Column<bool>(type: "bit", nullable: false),
                    FontIsItalic = table.Column<bool>(type: "bit", nullable: false),
                    FontSize = table.Column<int>(type: "int", nullable: false),
                    AlignRight = table.Column<bool>(type: "bit", nullable: false),
                    PaddingVertical = table.Column<int>(type: "int", nullable: false),
                    AlignTop = table.Column<bool>(type: "bit", nullable: false),
                    PaddingHorizontal = table.Column<int>(type: "int", nullable: false),
                    Xamount1 = table.Column<int>(type: "int", nullable: false),
                    Xamount2 = table.Column<int>(type: "int", nullable: false),
                    Yamount1 = table.Column<int>(type: "int", nullable: false),
                    Yamount2 = table.Column<int>(type: "int", nullable: false),
                    XtextAmount1 = table.Column<int>(type: "int", nullable: false),
                    XtextAmount2 = table.Column<int>(type: "int", nullable: false),
                    YtextAmount1 = table.Column<int>(type: "int", nullable: false),
                    YtextAmount2 = table.Column<int>(type: "int", nullable: false),
                    Xpayee1 = table.Column<int>(type: "int", nullable: false),
                    Xpayee2 = table.Column<int>(type: "int", nullable: false),
                    Ypayee1 = table.Column<int>(type: "int", nullable: false),
                    Ypayee2 = table.Column<int>(type: "int", nullable: false),
                    Xdate1 = table.Column<int>(type: "int", nullable: false),
                    Xdate2 = table.Column<int>(type: "int", nullable: false),
                    Ydate1 = table.Column<int>(type: "int", nullable: false),
                    Ydate2 = table.Column<int>(type: "int", nullable: false),
                    Xaddress1 = table.Column<int>(type: "int", nullable: false),
                    Xaddress2 = table.Column<int>(type: "int", nullable: false),
                    Yaddress1 = table.Column<int>(type: "int", nullable: false),
                    Yaddress2 = table.Column<int>(type: "int", nullable: false),
                    Xdiscription1 = table.Column<int>(type: "int", nullable: false),
                    Xdiscription2 = table.Column<int>(type: "int", nullable: false),
                    Ydiscription1 = table.Column<int>(type: "int", nullable: false),
                    Ydiscription2 = table.Column<int>(type: "int", nullable: false),
                    Xcomment1 = table.Column<int>(type: "int", nullable: false),
                    Xcomment2 = table.Column<int>(type: "int", nullable: false),
                    Ycomment1 = table.Column<int>(type: "int", nullable: false),
                    Ycomment2 = table.Column<int>(type: "int", nullable: false),
                    No = table.Column<int>(type: "int", nullable: false),
                    CreateById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankScemas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BankScemas_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BankScemas_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Chiques",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PayeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankBookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BankId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WrittenDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MatuityDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    CurrencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateById = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifyDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chiques", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chiques_BankBooks_BankBookId",
                        column: x => x.BankBookId,
                        principalTable: "BankBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Chiques_Banks_BankId",
                        column: x => x.BankId,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chiques_Chiqueaddresss_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Chiqueaddresss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chiques_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chiques_payees_PayeeId",
                        column: x => x.PayeeId,
                        principalTable: "payees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chiques_Users_CreateById",
                        column: x => x.CreateById,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChiqueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatusId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserLogs_Chiques_ChiqueId",
                        column: x => x.ChiqueId,
                        principalTable: "Chiques",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserLogs_statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserLogs_statuses_StatusId1",
                        column: x => x.StatusId1,
                        principalTable: "statuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserLogs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserLogs_Users_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankBooks_BankId",
                table: "BankBooks",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_BankBooks_CreateById",
                table: "BankBooks",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Banks_CreateById",
                table: "Banks",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_BankScemas_BankId",
                table: "BankScemas",
                column: "BankId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BankScemas_CreateById",
                table: "BankScemas",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Chiqueaddresss_CreateById",
                table: "Chiqueaddresss",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Chiques_AddressId",
                table: "Chiques",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Chiques_BankBookId",
                table: "Chiques",
                column: "BankBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Chiques_BankId",
                table: "Chiques",
                column: "BankId");

            migrationBuilder.CreateIndex(
                name: "IX_Chiques_CreateById",
                table: "Chiques",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_Chiques_CurrencyId",
                table: "Chiques",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Chiques_PayeeId",
                table: "Chiques",
                column: "PayeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Currencies_CreateById",
                table: "Currencies",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_payees_CreateById",
                table: "payees",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_statuses_CreateById",
                table: "statuses",
                column: "CreateById");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogs_ChiqueId",
                table: "UserLogs",
                column: "ChiqueId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogs_StatusId",
                table: "UserLogs",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogs_StatusId1",
                table: "UserLogs",
                column: "StatusId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogs_UserId",
                table: "UserLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogs_UserId1",
                table: "UserLogs",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CreateById",
                table: "Users",
                column: "CreateById");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankScemas");

            migrationBuilder.DropTable(
                name: "UserLogs");

            migrationBuilder.DropTable(
                name: "Chiques");

            migrationBuilder.DropTable(
                name: "statuses");

            migrationBuilder.DropTable(
                name: "BankBooks");

            migrationBuilder.DropTable(
                name: "Chiqueaddresss");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "payees");

            migrationBuilder.DropTable(
                name: "Banks");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

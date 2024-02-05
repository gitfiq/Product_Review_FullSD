using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Server.Migrations
{
    /// <inheritdoc />
    public partial class finalupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DeviceCodes",
                columns: table => new
                {
                    UserCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DeviceCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeviceCodes", x => x.UserCode);
                });

            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Version = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Use = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Algorithm = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsX509Certificate = table.Column<bool>(type: "bit", nullable: false),
                    DataProtected = table.Column<bool>(type: "bit", nullable: false),
                    Data = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersistedGrants",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SessionId = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ClientId = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Expiration = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ConsumedTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Data = table.Column<string>(type: "nvarchar(max)", maxLength: 50000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersistedGrants", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebsiteLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publishers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookRating = table.Column<double>(type: "float", nullable: false),
                    PublishYear = table.Column<int>(type: "int", nullable: false),
                    Edition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SchoolLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(MAX)", nullable: true),
                    PublisherID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Publishers_PublisherID",
                        column: x => x.PublisherID,
                        principalTable: "Publishers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthorDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorID = table.Column<int>(type: "int", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthorDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookAuthorDetails_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthorDetails_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recommendations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StaffRating = table.Column<double>(type: "float", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recommendations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recommendations_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Recommendations_Staffs_StaffID",
                        column: x => x.StaffID,
                        principalTable: "Staffs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserRating = table.Column<double>(type: "float", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    BookID = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AppUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AppUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "EmailAddress", "FirstName", "Gender", "LastName", "Password", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4169), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4184), "rayleong@bookmail.com", "Ray", "Male", "Leong", "password", "System", "User_Ray" },
                    { 2, "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4189), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4190), "afiq@bookmail.com", "Ahmad", "Male", "Afiq", "password", "System", "User_Afiq" }
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "cf2b85c6-cc5a-47d9-82c7-e87616f94e0a", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEMOenRFqQ3heOXhN7F/aDWqJJKzRiSCsBGoG598xjiMUaRFxaAqLfOIwSpeV6bDNkw==", null, false, "dabd85e5-4b76-440e-a13e-bdff6c774022", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Biography", "ContactInfo", "CreatedBy", "DateCreated", "DateUpdated", "EmailAddress", "FirstName", "LastName", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Roald Dahl (1916-1990) was a prolific British author renowned for his captivating and whimsical children's literature. Born in Wales, Dahl's diverse career began as a fighter pilot in World War II before he found success as a writer. His imaginative tales, such as \"Charlie and the Chocolate Factory,\" \"Matilda,\" and \"James and the Giant Peach,\" have become timeless classics, celebrated for their dark humor and memorable characters. Dahl's unique storytelling and vivid imagination earned him widespread acclaim, making him one of the most beloved and influential children's authors of the 20th century. His legacy endures, enchanting readers of all ages.", "22446688", "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4816), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4817), "roalddahl@bookmail.com", "Roald", "Dahl", "System" },
                    { 2, "George Orwell (1903-1950), born Eric Arthur Blair in India, was a British writer and journalist renowned for his penetrating social and political critiques. Best known for dystopian classics \"Nineteen Eighty-Four\" and \"Animal Farm,\" Orwell delved into the perils of totalitarianism and the abuse of power. A committed democratic socialist, his experiences during the Spanish Civil War and reflections on totalitarian regimes fueled his compelling narratives. Orwell's non-fiction works, including \"Homage to Catalonia\" and \"Down and Out in Paris and London,\" displayed a keen eye for societal injustice. His incisive prose and commitment to truth make Orwell a literary giant whose influence persists globally.", "11335577", "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4821), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4822), "georgeorwell@bookmail.com", "George", "Orwell", "System" },
                    { 3, "J.R.R. Tolkien (born January 3, 1892, Bloemfontein, South Africa—died September 2, 1973, Bournemouth, Hampshire, England) English writer and scholar who achieved fame with his children's book The Hobbit (1937) and his richly inventive epic fantasy The Lord of the Rings ", "48591526", "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4824), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4825), "jrrtolkien@bookmail.com", "J.R.R", "Tolkien", "System" },
                    { 4, "J.K. Rowling, born Joanne Rowling on July 31, 1965, in Yate, Gloucestershire, England, is a British author best known for creating the immensely popular \"Harry Potter\" series. Rowling's journey to literary fame began with the idea for the series during a train journey in 1990. Over the next several years, she meticulously outlined the seven-book saga, which follows the magical adventures of the young wizard Harry Potter and his friends.", "35246857", "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4827), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(4828), "jkrowling@bookmail.com", "J.K", "Rowling", "System" }
                });

            migrationBuilder.InsertData(
                table: "Publishers",
                columns: new[] { "Id", "Address", "ContactInfo", "CreatedBy", "DateCreated", "DateUpdated", "EmailAddress", "PublisherName", "UpdatedBy", "WebsiteLink" },
                values: new object[,]
                {
                    { 1, "15 Serangoon North Avenue 5, Singapore 554360", "64629603", "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(6403), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(6405), "eph@popularworld.com", "Educational Publishing House", "System", "https://www.eph.com.sg/" },
                    { 2, "Bukit Merah Central, #02-07 Block 1003, Singapore 159836", "65748432", "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(6416), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(6417), "ap@arpub.com", "Armour Publishing", "System", "https://armourpublishing.com/" }
                });

            migrationBuilder.InsertData(
                table: "Staffs",
                columns: new[] { "Id", "ContactInfo", "CreatedBy", "DateCreated", "DateUpdated", "EmailAddress", "FirstName", "LastName", "Password", "UpdatedBy", "Username" },
                values: new object[] { 1, "87907564", "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(6172), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(6173), "admin1@blazor.com", "Sam", "Wick", "Abc123!", "System", "admin1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookRating", "CreatedBy", "DateCreated", "DateUpdated", "Description", "Edition", "Image", "NumberOfPages", "PublishYear", "PublisherID", "SchoolLevel", "Subject", "Title", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 5.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Dursleys were so mean and hideous that summer that all Harry Potter wanted was to get back to the Hogwarts School for Witchcraft and Wizardry. But just as he's packing his bags, Harry receives a warning from a strange, impish creature named Dobby who says that if Harry Potter returns to Hogwarts, disaster will strike.And strike it does. For in Harry's second year at Hogwarts, fresh torments and horrors arise, including an outrageously stuck-up new professor, Gilderoy Lockhart, a spirit named Moaning Myrtle who haunts the girls' bathroom, and the unwanted attentions of Ron Weasley's younger sister, Ginny.But each of these seem minor annoyances when the real trouble begins, and someone -- or something -- starts turning Hogwarts students to stone. Could it be Draco Malfoy, a more poisonous rival than ever? Could it possibly be Hagrid, whose mysterious past is finally told? Or could it be the one everyone at Hogwarts most suspects... Harry Potter himself?", "1", null, 200, 2014, 1, "Primary 5", "English", "Harry Potter", null },
                    { 2, 5.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "One Ring to rule them all, One Ring to find them, One Ring to bring them all and in the darkness bind them.\r\n\r\nIn ancient times the Rings of Power were crafted by the Elven-smiths, and Sauron, the Dark Lord, forged the One Ring, filling it with his own power so that he could rule all others. But the One Ring was taken from him, and though he sought it throughout Middle-earth, it remained lost to him. After many ages it fell by chance into the hands of the hobbit Bilbo Baggins.\r\n\r\nFrom Sauron's fastness in the Dark Tower of Mordor, his power spread far and wide. Sauron gathered all the Great Rings to him, but always he searched for the One Ring that would complete his dominion.\r\n\r\nWhen Bilbo reached his eleventy-first birthday he disappeared, bequeathing to his young cousin Frodo the Ruling Ring and a perilous quest: to journey across Middle-earth, deep into the shadow of the Dark Lord, and destroy the Ring by casting it into the Cracks of Doom.", "1", null, 250, 2015, 1, "Secondary 1", "English", "Lord Of The Rings", null },
                    { 3, 4.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The family film told from the dog’s perspective also stars Britt Robertson, KJ Apa, John Ortiz, Peggy Lipton, Juliet Rylance, Luke Kirby, Pooch Hall and Dennis Quaid. A Dog’s Purpose is produced by Gavin Polone (Zombieland, TV’s Gilmore Girls). The film from Amblin Entertainment and Walden Media will be distributed by Universal Pictures. Screenplay by W. Bruce Cameron & Cathryn Michon and Audrey Wells and Maya Forbes & Wally Wolodarsky.\r\n\r\nHeartwarming, insightful, and often laugh-out-loud funny, A Dog's Purpose is not only the emotional and hilarious story of a dog's many lives, but also a dog's-eye commentary on human relationships and the unbreakable bonds between man and man's best friend. This moving and beautifully crafted story teaches us that love never dies, that our true friends are always with us, and that every creature on earth is born with a purpose.", "1", null, 336, 2015, 1, "Secondary 1", "English", "A Dog's Purpose: A Novel for Humans", null },
                    { 4, 3.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The boy has lived his whole life trapped within a book-choked chamber older than empires and larger than cities.\r\n\r\nThe girl has been plucked from the outskirts of civilization to be trained as a librarian, studying the mysteries of the great library at the heart of her kingdom.They were never supposed to meet. But in the library, they did.\r\n\r\nTheir stories spiral around each other, across worlds and time. This is a tale of truth and lies and hearts, and the blurring of one into another. A journey on which knowledge erodes certainty and on which, though the pen may be mightier than the sword, blood will be spilled and cities burned.", "1", null, 421, 2015, 1, "Secondary 1", "English", "The Book That Wouldn't Burn", null },
                    { 5, 3.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The third book in the Harry Potter series, illustrated in brilliant full color by MinaLima and featuring eight exclusive interactive elements, including the Marauder’s Map and more!Return to Hogwarts in this stunning edition of Harry Potter and the Prisoner of Azkaban. J.K. Rowling’s complete and unabridged text is accompanied by full-color illustrations on nearly every page and eight paper-engineered interactive elements: Readers will explore the Knight Bus, reveal the Grim in a teacup, spin the Time-Turner, and more.\r\n\r\nDesigned and illustrated by MinaLima ― the award-winning studio behind the graphic style of the Harry Potter films ― this keepsake edition is the perfect gift for Harry Potter fans of all ages, a beautiful addition to any collector’s bookshelf, and an enchanting way to share this beloved series with a new generation of readers.", "1", null, 421, 2015, 1, "Secondary 1", "English", "Harry Potter and the Prisoner of Azkaban ", null },
                    { 6, 3.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Interstellar, from acclaimed filmmaker Christopher Nolan, takes us on a fantastic voyage far beyond our solar system. Yet in The Science of Interstellar, Kip Thorne, the Nobel prize-winning physicist who assisted Nolan on the scientific aspects of Interstellar, shows us that the movie’s jaw-dropping events and stunning, never-before-attempted visuals are grounded in real science. Thorne shares his experiences working as the science adviser on the film and then moves on to the science itself. In chapters on wormholes, black holes, interstellar travel, and much more, Thorne’s scientific insights―many of them triggered during the actual scripting and shooting of Interstellar―describe the physical laws that govern our universe and the truly astounding phenomena that those laws make possible.", "1", null, 421, 2015, 1, "Secondary 1", "English", "The Science of Interstellar", null },
                    { 7, 3.0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Everyone expected Violet Sorrengail to die during her first year at Basgiath War College—Violet included. But Threshing was only the first impossible test meant to weed out the weak-willed, the unworthy, and the unlucky.\r\n\r\nNow the real training begins, and Violet’s already wondering how she’ll get through. It’s not just that it’s grueling and maliciously brutal, or even that it’s designed to stretch the riders’ capacity for pain beyond endurance. It’s the new vice commandant, who’s made it his personal mission to teach Violet exactly how powerless she is–unless she betrays the man she loves.\r\n\r\nAlthough Violet’s body might be weaker and frailer than everyone else’s, she still has her wits—and a will of iron. And leadership is forgetting the most important lesson Basgiath has taught her: Dragon riders make their own rules.\r\n\r\nBut a determination to survive won’t be enough this year.\r\n\r\nBecause Violet knows the real secret hidden for centuries at Basgiath War College—and nothing, not even dragon fire, may be enough to save them in the end.\r\n\r\nThe Empyrean series is best enjoyed in order.\r\nReading Order:\r\nBook #1 Fourth Wing\r\nBook #2 Iron Flame", "1", null, 421, 2015, 1, "Secondary 1", "English", "Iron Flame (The Empyrean Book 2) ", null }
                });

            migrationBuilder.InsertData(
                table: "BookAuthorDetails",
                columns: new[] { "Id", "AuthorID", "BookID", "CreatedBy", "DateCreated", "DateUpdated", "UpdatedBy" },
                values: new object[] { 1, 1, 1, "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(5671), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(5673), "System" });

            migrationBuilder.InsertData(
                table: "Recommendations",
                columns: new[] { "Id", "BookID", "CreatedBy", "Date", "DateCreated", "DateUpdated", "Description", "StaffID", "StaffRating", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(5925), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(5927), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(5928), "This boook is very lovely and i recommended you to read it", 1, 4.5, "System" },
                    { 2, 2, "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(5930), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(5932), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(5933), "This book is amazing. It provides, a glimpse of the workforce world. I highly recommend it to the young adults that is searching for a job", 1, 5.0, "System" }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AppUserID", "BookID", "Content", "CreatedBy", "DateCreated", "DateUpdated", "Title", "UpdatedBy", "UserRating" },
                values: new object[] { 1, 1, 1, "This book has changed my life, and I would highly recommend this to anyone who is in school.", "System", new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(5318), new DateTime(2024, 2, 5, 10, 35, 7, 217, DateTimeKind.Local).AddTicks(5319), "I love this book", "System", 4.0 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthorDetails_AuthorID",
                table: "BookAuthorDetails",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthorDetails_BookID",
                table: "BookAuthorDetails",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_Books_PublisherID",
                table: "Books",
                column: "PublisherID");

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_DeviceCode",
                table: "DeviceCodes",
                column: "DeviceCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DeviceCodes_Expiration",
                table: "DeviceCodes",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_Keys_Use",
                table: "Keys",
                column: "Use");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_ConsumedTime",
                table: "PersistedGrants",
                column: "ConsumedTime");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_Expiration",
                table: "PersistedGrants",
                column: "Expiration");

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_ClientId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "ClientId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_PersistedGrants_SubjectId_SessionId_Type",
                table: "PersistedGrants",
                columns: new[] { "SubjectId", "SessionId", "Type" });

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_BookID",
                table: "Recommendations",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_Recommendations_StaffID",
                table: "Recommendations",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AppUserID",
                table: "Reviews",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_BookID",
                table: "Reviews",
                column: "BookID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BookAuthorDetails");

            migrationBuilder.DropTable(
                name: "DeviceCodes");

            migrationBuilder.DropTable(
                name: "Keys");

            migrationBuilder.DropTable(
                name: "PersistedGrants");

            migrationBuilder.DropTable(
                name: "Recommendations");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Staffs");

            migrationBuilder.DropTable(
                name: "AppUsers");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Publishers");
        }
    }
}

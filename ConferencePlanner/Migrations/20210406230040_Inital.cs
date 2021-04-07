using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConferenceManager.Migrations
{
    public partial class Inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendees",
                columns: table => new
                {
                    AttendeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 20, nullable: false),
                    LastName = table.Column<string>(maxLength: 20, nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 50, nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: false),
                    IsPresenter = table.Column<bool>(nullable: false),
                    IsStaff = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendees", x => x.AttendeeID);
                });

            migrationBuilder.CreateTable(
                name: "Conferences",
                columns: table => new
                {
                    ConferenceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conferences", x => x.ConferenceID);
                });

            migrationBuilder.CreateTable(
                name: "Venue",
                columns: table => new
                {
                    VenueID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Address1 = table.Column<string>(maxLength: 20, nullable: false),
                    Address2 = table.Column<string>(maxLength: 20, nullable: true),
                    City = table.Column<string>(maxLength: 20, nullable: false),
                    State = table.Column<string>(maxLength: 2, nullable: false),
                    PostalCode = table.Column<string>(maxLength: 20, nullable: false),
                    Phone = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venue", x => x.VenueID);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenueID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    TheatreCapacity = table.Column<int>(nullable: true),
                    SchoolRoomCapacity = table.Column<int>(nullable: true),
                    CrescentRoundCapacity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Rooms_Venue_VenueID",
                        column: x => x.VenueID,
                        principalTable: "Venue",
                        principalColumn: "VenueID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Presentations",
                columns: table => new
                {
                    PresentationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConferenceID = table.Column<int>(nullable: false),
                    RoomID = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    AttendeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presentations", x => x.PresentationID);
                    table.ForeignKey(
                        name: "FK_Presentations_Attendees_AttendeeID",
                        column: x => x.AttendeeID,
                        principalTable: "Attendees",
                        principalColumn: "AttendeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presentations_Conferences_ConferenceID",
                        column: x => x.ConferenceID,
                        principalTable: "Conferences",
                        principalColumn: "ConferenceID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Presentations_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Attendees",
                columns: new[] { "AttendeeID", "DateRegistered", "Email", "FirstName", "IsPresenter", "IsStaff", "LastName", "Phone" },
                values: new object[,]
                {
                    { 101, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "steve@juno.com", "Steve", true, false, "Johnson", "303-303-3030" },
                    { 102, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "dave@juno.com", "Dave", true, false, "Jackson", "303-303-3031" },
                    { 103, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "cherrith@marritimelaw.com", "Cherrith", false, false, "Goodstory", "303-303-3032" },
                    { 104, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "friz@wb.com", "Friz", true, false, "Freeling", "303-303-3033" },
                    { 105, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "wil@varoom.com", "Wile E", true, false, "Coyote", "303-303-3034" },
                    { 106, new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local), "bill@compuserve.com", "Bill", false, false, "Smith", "303-303-3035" }
                });

            migrationBuilder.InsertData(
                table: "Conferences",
                columns: new[] { "ConferenceID", "Description", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1001, "The largest gathering of national association directors and managers in the world.", new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Local), "International Association of National Associations", new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 1002, "An exposition of the latest in roadrunner hunting equipment", new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Local), "Acme Corp", new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Venue",
                columns: new[] { "VenueID", "Address1", "Address2", "City", "Name", "Phone", "PostalCode", "State" },
                values: new object[,]
                {
                    { 10, "700 14th St", null, "Denver", "Colorado Convention Center", "303-303-0000", "80202", "CO" },
                    { 11, "1405 Curtis St", null, "Denver", "The Curtis Hotel", "720-303-0000", "80202", "CO" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "RoomID", "CrescentRoundCapacity", "Name", "SchoolRoomCapacity", "TheatreCapacity", "VenueID" },
                values: new object[,]
                {
                    { 1010, 65, "101", 50, 100, 10 },
                    { 1011, 65, "201", 50, 100, 10 },
                    { 1012, 650, "Mile High Ballroom", 500, 1000, 10 },
                    { 1013, 350, "Marco Polo Ballroom", 250, 500, 11 },
                    { 1014, 65, "Red Rover", 50, 100, 11 }
                });

            migrationBuilder.InsertData(
                table: "Presentations",
                columns: new[] { "PresentationID", "AttendeeID", "ConferenceID", "Description", "EndTime", "Name", "RoomID", "StartTime" },
                values: new object[,]
                {
                    { 101, 102, 1001, "Hear our president discuss the role of professional organizations in the 21st century", new DateTime(2021, 4, 7, 19, 0, 39, 867, DateTimeKind.Local).AddTicks(1262), "Professional Associations in the 21st century", 1010, new DateTime(2021, 4, 7, 17, 0, 39, 867, DateTimeKind.Local).AddTicks(856) },
                    { 102, 101, 1001, "Join a discussion about the various services a professional organization can offer it's members", new DateTime(2021, 4, 8, 19, 0, 39, 867, DateTimeKind.Local).AddTicks(1744), "Member Services", 1011, new DateTime(2021, 4, 8, 17, 0, 39, 867, DateTimeKind.Local).AddTicks(1728) },
                    { 103, 104, 1002, "Learn about the proper application of our tunnel paint in dry arid climates.", new DateTime(2021, 4, 8, 19, 0, 39, 867, DateTimeKind.Local).AddTicks(1756), "Paint Application in Aird Climates", 1011, new DateTime(2021, 4, 8, 17, 0, 39, 867, DateTimeKind.Local).AddTicks(1753) },
                    { 104, 105, 1002, "Our rockets aren't just for hunting! Come hear about Acme's plans to land the first coyote on the moon", new DateTime(2021, 4, 8, 19, 0, 39, 867, DateTimeKind.Local).AddTicks(1761), "Acme Orbital", 1013, new DateTime(2021, 4, 8, 17, 0, 39, 867, DateTimeKind.Local).AddTicks(1759) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Presentations_AttendeeID",
                table: "Presentations",
                column: "AttendeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Presentations_ConferenceID",
                table: "Presentations",
                column: "ConferenceID");

            migrationBuilder.CreateIndex(
                name: "IX_Presentations_RoomID",
                table: "Presentations",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_VenueID",
                table: "Rooms",
                column: "VenueID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presentations");

            migrationBuilder.DropTable(
                name: "Attendees");

            migrationBuilder.DropTable(
                name: "Conferences");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Venue");
        }
    }
}

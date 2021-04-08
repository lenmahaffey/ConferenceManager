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
                    ID = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_Attendees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Conferences",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conferences", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Venues",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
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
                    table.PrimaryKey("PK_Venues", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ConferenceAttendees",
                columns: table => new
                {
                    ConferenceID = table.Column<int>(nullable: false),
                    AttendeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConferenceAttendees", x => new { x.ConferenceID, x.AttendeeID });
                    table.ForeignKey(
                        name: "FK_ConferenceAttendees_Attendees_AttendeeID",
                        column: x => x.AttendeeID,
                        principalTable: "Attendees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConferenceAttendees_Conferences_ConferenceID",
                        column: x => x.ConferenceID,
                        principalTable: "Conferences",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ConferenceVenues",
                columns: table => new
                {
                    ConferenceID = table.Column<int>(nullable: false),
                    VenueID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConferenceVenues", x => new { x.ConferenceID, x.VenueID });
                    table.ForeignKey(
                        name: "FK_ConferenceVenues_Conferences_ConferenceID",
                        column: x => x.ConferenceID,
                        principalTable: "Conferences",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConferenceVenues_Venues_VenueID",
                        column: x => x.VenueID,
                        principalTable: "Venues",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VenueID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    TheatreCapacity = table.Column<int>(nullable: true),
                    SchoolRoomCapacity = table.Column<int>(nullable: true),
                    CrescentRoundCapacity = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Rooms_Venues_VenueID",
                        column: x => x.VenueID,
                        principalTable: "Venues",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Event",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConferenceID = table.Column<int>(nullable: false),
                    RoomID = table.Column<int>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    AttendeeID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Event", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Event_Attendees_AttendeeID",
                        column: x => x.AttendeeID,
                        principalTable: "Attendees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_Conferences_ConferenceID",
                        column: x => x.ConferenceID,
                        principalTable: "Conferences",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Event_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EventAttendees",
                columns: table => new
                {
                    EventID = table.Column<int>(nullable: false),
                    AttendeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventAttendees", x => new { x.EventID, x.AttendeeID });
                    table.ForeignKey(
                        name: "FK_EventAttendees_Attendees_AttendeeID",
                        column: x => x.AttendeeID,
                        principalTable: "Attendees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EventAttendees_Event_EventID",
                        column: x => x.EventID,
                        principalTable: "Event",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Attendees",
                columns: new[] { "ID", "DateRegistered", "Email", "FirstName", "IsPresenter", "IsStaff", "LastName", "Phone" },
                values: new object[,]
                {
                    { 101, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "steve@juno.com", "Steve", true, false, "Johnson", "303-303-3030" },
                    { 102, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "dave@juno.com", "Dave", true, false, "Jackson", "303-303-3031" },
                    { 103, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "cherrith@marritimelaw.com", "Cherrith", false, false, "Goodstory", "303-303-3032" },
                    { 104, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "friz@wb.com", "Friz", true, false, "Freeling", "303-303-3033" },
                    { 105, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "wil@varoom.com", "Wile E", true, false, "Coyote", "303-303-3034" },
                    { 106, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Local), "bill@compuserve.com", "Bill", false, false, "Smith", "303-303-3035" }
                });

            migrationBuilder.InsertData(
                table: "Conferences",
                columns: new[] { "ID", "Description", "EndDate", "Name", "StartDate" },
                values: new object[,]
                {
                    { 1001, "The largest gathering of national association directors and managers in the world.", new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Local), "International Association of National Associations", new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Local) },
                    { 1002, "An exposition of the latest in roadrunner hunting equipment", new DateTime(2021, 4, 17, 0, 0, 0, 0, DateTimeKind.Local), "Acme Corp", new DateTime(2021, 4, 13, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Venues",
                columns: new[] { "ID", "Address1", "Address2", "City", "Name", "Phone", "PostalCode", "State" },
                values: new object[,]
                {
                    { 10, "700 14th St", null, "Denver", "Colorado Convention Center", "303-303-0000", "80202", "CO" },
                    { 11, "1405 Curtis St", null, "Denver", "The Curtis Hotel", "720-303-0000", "80202", "CO" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "ID", "CrescentRoundCapacity", "Name", "SchoolRoomCapacity", "TheatreCapacity", "VenueID" },
                values: new object[,]
                {
                    { 1010, 65, "101", 50, 100, 10 },
                    { 1011, 65, "201", 50, 100, 10 },
                    { 1012, 650, "Mile High Ballroom", 500, 1000, 10 },
                    { 1013, 350, "Marco Polo Ballroom", 250, 500, 11 },
                    { 1014, 65, "Red Rover", 50, 100, 11 }
                });

            migrationBuilder.InsertData(
                table: "Event",
                columns: new[] { "ID", "ConferenceID", "Description", "Discriminator", "EndTime", "Name", "RoomID", "StartTime", "AttendeeID" },
                values: new object[,]
                {
                    { 101, 1001, "Hear our president discuss the role of professional organizations in the 21st century", "Presentation", new DateTime(2021, 4, 9, 18, 58, 24, 603, DateTimeKind.Local).AddTicks(6532), "Professional Associations in the 21st century", 1010, new DateTime(2021, 4, 9, 16, 58, 24, 603, DateTimeKind.Local).AddTicks(6132), 102 },
                    { 102, 1001, "Join a discussion about the various services a professional organization can offer it's members", "Presentation", new DateTime(2021, 4, 10, 18, 58, 24, 603, DateTimeKind.Local).AddTicks(7010), "Member Services", 1011, new DateTime(2021, 4, 10, 16, 58, 24, 603, DateTimeKind.Local).AddTicks(6994), 101 },
                    { 103, 1002, "Learn about the proper application of our tunnel paint in dry arid climates.", "Presentation", new DateTime(2021, 4, 10, 18, 58, 24, 603, DateTimeKind.Local).AddTicks(7021), "Paint Application in Aird Climates", 1011, new DateTime(2021, 4, 10, 16, 58, 24, 603, DateTimeKind.Local).AddTicks(7019), 104 },
                    { 104, 1002, "Our rockets aren't just for hunting! Come hear about Acme's plans to land the first coyote on the moon", "Presentation", new DateTime(2021, 4, 10, 18, 58, 24, 603, DateTimeKind.Local).AddTicks(7026), "Acme Orbital", 1013, new DateTime(2021, 4, 10, 16, 58, 24, 603, DateTimeKind.Local).AddTicks(7024), 105 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ConferenceAttendees_AttendeeID",
                table: "ConferenceAttendees",
                column: "AttendeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ConferenceVenues_VenueID",
                table: "ConferenceVenues",
                column: "VenueID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_AttendeeID",
                table: "Event",
                column: "AttendeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_ConferenceID",
                table: "Event",
                column: "ConferenceID");

            migrationBuilder.CreateIndex(
                name: "IX_Event_RoomID",
                table: "Event",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_EventAttendees_AttendeeID",
                table: "EventAttendees",
                column: "AttendeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_VenueID",
                table: "Rooms",
                column: "VenueID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConferenceAttendees");

            migrationBuilder.DropTable(
                name: "ConferenceVenues");

            migrationBuilder.DropTable(
                name: "EventAttendees");

            migrationBuilder.DropTable(
                name: "Event");

            migrationBuilder.DropTable(
                name: "Attendees");

            migrationBuilder.DropTable(
                name: "Conferences");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Venues");
        }
    }
}

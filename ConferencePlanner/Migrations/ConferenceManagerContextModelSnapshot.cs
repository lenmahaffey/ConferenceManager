﻿// <auto-generated />
using System;
using ConferenceManager.Services.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConferenceManager.Migrations
{
    [DbContext(typeof(ConferenceManagerContext))]
    partial class ConferenceManagerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConferenceManager.Models.Entities.Attendee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("IsPresenter")
                        .HasColumnType("bit");

                    b.Property<bool>("IsStaff")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Attendees");

                    b.HasData(
                        new
                        {
                            ID = 101,
                            DateRegistered = new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "steve@juno.com",
                            FirstName = "Steve",
                            IsPresenter = true,
                            IsStaff = false,
                            LastName = "Johnson",
                            Phone = "303-303-3030"
                        },
                        new
                        {
                            ID = 102,
                            DateRegistered = new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "dave@juno.com",
                            FirstName = "Dave",
                            IsPresenter = true,
                            IsStaff = false,
                            LastName = "Jackson",
                            Phone = "303-303-3031"
                        },
                        new
                        {
                            ID = 103,
                            DateRegistered = new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "cherrith@marritimelaw.com",
                            FirstName = "Cherrith",
                            IsPresenter = false,
                            IsStaff = false,
                            LastName = "Goodstory",
                            Phone = "303-303-3032"
                        },
                        new
                        {
                            ID = 104,
                            DateRegistered = new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "friz@wb.com",
                            FirstName = "Friz",
                            IsPresenter = true,
                            IsStaff = false,
                            LastName = "Freeling",
                            Phone = "303-303-3033"
                        },
                        new
                        {
                            ID = 105,
                            DateRegistered = new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "wil@varoom.com",
                            FirstName = "Wile E",
                            IsPresenter = true,
                            IsStaff = false,
                            LastName = "Coyote",
                            Phone = "303-303-3034"
                        },
                        new
                        {
                            ID = 106,
                            DateRegistered = new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            Email = "bill@compuserve.com",
                            FirstName = "Bill",
                            IsPresenter = false,
                            IsStaff = false,
                            LastName = "Smith",
                            Phone = "303-303-3035"
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Conference", b =>
                {
                    b.Property<int>("ConferenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ConferenceID");

                    b.ToTable("Conferences");

                    b.HasData(
                        new
                        {
                            ConferenceID = 1001,
                            Description = "The largest gathering of national association directors and managers in the world.",
                            EndDate = new DateTime(2021, 4, 10, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "International Association of National Associations",
                            StartDate = new DateTime(2021, 4, 6, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ConferenceID = 1002,
                            Description = "An exposition of the latest in roadrunner hunting equipment",
                            EndDate = new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Acme Corp",
                            StartDate = new DateTime(2021, 4, 11, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.ConferenceAttendees", b =>
                {
                    b.Property<int>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<int>("AttendeeID")
                        .HasColumnType("int");

                    b.HasKey("ConferenceID", "AttendeeID");

                    b.HasIndex("AttendeeID");

                    b.ToTable("ConferenceAttendees");
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.ConferenceVenues", b =>
                {
                    b.Property<int>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<int>("VenueID")
                        .HasColumnType("int");

                    b.HasKey("ConferenceID", "VenueID");

                    b.HasIndex("VenueID");

                    b.ToTable("ConferenceVenues");
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.HasIndex("ConferenceID");

                    b.HasIndex("RoomID");

                    b.ToTable("Events");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Event");
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.EventAttendees", b =>
                {
                    b.Property<int>("EventID")
                        .HasColumnType("int");

                    b.Property<int>("AttendeeID")
                        .HasColumnType("int");

                    b.HasKey("EventID", "AttendeeID");

                    b.HasIndex("AttendeeID");

                    b.ToTable("EventAttendees");
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CrescentRoundCapacity")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int?>("SchoolRoomCapacity")
                        .HasColumnType("int");

                    b.Property<int?>("TheatreCapacity")
                        .HasColumnType("int");

                    b.Property<int>("VenueID")
                        .HasColumnType("int");

                    b.HasKey("RoomID");

                    b.HasIndex("VenueID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            RoomID = 1010,
                            CrescentRoundCapacity = 65,
                            Name = "101",
                            SchoolRoomCapacity = 50,
                            TheatreCapacity = 100,
                            VenueID = 10
                        },
                        new
                        {
                            RoomID = 1011,
                            CrescentRoundCapacity = 65,
                            Name = "201",
                            SchoolRoomCapacity = 50,
                            TheatreCapacity = 100,
                            VenueID = 10
                        },
                        new
                        {
                            RoomID = 1012,
                            CrescentRoundCapacity = 650,
                            Name = "Mile High Ballroom",
                            SchoolRoomCapacity = 500,
                            TheatreCapacity = 1000,
                            VenueID = 10
                        },
                        new
                        {
                            RoomID = 1013,
                            CrescentRoundCapacity = 350,
                            Name = "Marco Polo Ballroom",
                            SchoolRoomCapacity = 250,
                            TheatreCapacity = 500,
                            VenueID = 11
                        },
                        new
                        {
                            RoomID = 1014,
                            CrescentRoundCapacity = 65,
                            Name = "Red Rover",
                            SchoolRoomCapacity = 50,
                            TheatreCapacity = 100,
                            VenueID = 11
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Venue", b =>
                {
                    b.Property<int>("VenueID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Address2")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.HasKey("VenueID");

                    b.ToTable("Venues");

                    b.HasData(
                        new
                        {
                            VenueID = 10,
                            Address1 = "700 14th St",
                            City = "Denver",
                            Name = "Colorado Convention Center",
                            Phone = "303-303-0000",
                            PostalCode = "80202",
                            State = "CO"
                        },
                        new
                        {
                            VenueID = 11,
                            Address1 = "1405 Curtis St",
                            City = "Denver",
                            Name = "The Curtis Hotel",
                            Phone = "720-303-0000",
                            PostalCode = "80202",
                            State = "CO"
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Presentation", b =>
                {
                    b.HasBaseType("ConferenceManager.Models.Entities.Event");

                    b.Property<int>("AttendeeID")
                        .HasColumnType("int");

                    b.Property<int?>("RoomID1")
                        .HasColumnType("int");

                    b.HasIndex("AttendeeID");

                    b.HasIndex("RoomID1");

                    b.HasDiscriminator().HasValue("Presentation");

                    b.HasData(
                        new
                        {
                            ID = 101,
                            ConferenceID = 1001,
                            Description = "Hear our president discuss the role of professional organizations in the 21st century",
                            EndTime = new DateTime(2021, 4, 7, 23, 54, 1, 306, DateTimeKind.Local).AddTicks(5266),
                            Name = "Professional Associations in the 21st century",
                            RoomID = 1010,
                            StartTime = new DateTime(2021, 4, 7, 21, 54, 1, 306, DateTimeKind.Local).AddTicks(4858),
                            AttendeeID = 102
                        },
                        new
                        {
                            ID = 102,
                            ConferenceID = 1001,
                            Description = "Join a discussion about the various services a professional organization can offer it's members",
                            EndTime = new DateTime(2021, 4, 8, 23, 54, 1, 306, DateTimeKind.Local).AddTicks(5769),
                            Name = "Member Services",
                            RoomID = 1011,
                            StartTime = new DateTime(2021, 4, 8, 21, 54, 1, 306, DateTimeKind.Local).AddTicks(5752),
                            AttendeeID = 101
                        },
                        new
                        {
                            ID = 103,
                            ConferenceID = 1002,
                            Description = "Learn about the proper application of our tunnel paint in dry arid climates.",
                            EndTime = new DateTime(2021, 4, 8, 23, 54, 1, 306, DateTimeKind.Local).AddTicks(5780),
                            Name = "Paint Application in Aird Climates",
                            RoomID = 1011,
                            StartTime = new DateTime(2021, 4, 8, 21, 54, 1, 306, DateTimeKind.Local).AddTicks(5778),
                            AttendeeID = 104
                        },
                        new
                        {
                            ID = 104,
                            ConferenceID = 1002,
                            Description = "Our rockets aren't just for hunting! Come hear about Acme's plans to land the first coyote on the moon",
                            EndTime = new DateTime(2021, 4, 8, 23, 54, 1, 306, DateTimeKind.Local).AddTicks(5786),
                            Name = "Acme Orbital",
                            RoomID = 1013,
                            StartTime = new DateTime(2021, 4, 8, 21, 54, 1, 306, DateTimeKind.Local).AddTicks(5783),
                            AttendeeID = 105
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.ConferenceAttendees", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.Attendee", "Attendee")
                        .WithMany("ConferenceAttendees")
                        .HasForeignKey("AttendeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Entities.Conference", "Conference")
                        .WithMany("ConferenceAttendees")
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.ConferenceVenues", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.Conference", "Conference")
                        .WithMany("ConferenceVenues")
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Entities.Venue", "Venue")
                        .WithMany("ConferenceVenues")
                        .HasForeignKey("VenueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Event", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.Conference", "Conference")
                        .WithMany("Presentations")
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Entities.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.EventAttendees", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.Attendee", "Attendee")
                        .WithMany("EventAttendees")
                        .HasForeignKey("AttendeeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Entities.Event", "Event")
                        .WithMany("EventAttendees")
                        .HasForeignKey("EventID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Room", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.Venue", "Venue")
                        .WithMany("Rooms")
                        .HasForeignKey("VenueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Presentation", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.Attendee", "Attendee")
                        .WithMany()
                        .HasForeignKey("AttendeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Entities.Room", null)
                        .WithMany("Presentations")
                        .HasForeignKey("RoomID1");
                });
#pragma warning restore 612, 618
        }
    }
}

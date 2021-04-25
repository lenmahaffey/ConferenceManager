﻿// <auto-generated />
using System;
using ConferenceManager.Services.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConferenceManager.Migrations
{
    [DbContext(typeof(ConferenceManagerContext))]
    [Migration("20210425035828_Identity")]
    partial class Identity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConferenceManager.Models.Entities.Conference", b =>
                {
                    b.Property<int>("ID")
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

                    b.HasKey("ID");

                    b.ToTable("Conferences");

                    b.HasData(
                        new
                        {
                            ID = 1001,
                            Description = "The largest gathering of national association directors and managers in the world.",
                            EndDate = new DateTime(2021, 4, 28, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "International Association of National Associations",
                            StartDate = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            ID = 1002,
                            Description = "An exposition of the latest in roadrunner hunting equipment",
                            EndDate = new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Local),
                            Name = "Acme Corp",
                            StartDate = new DateTime(2021, 4, 29, 0, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.ConferenceAttendee", b =>
                {
                    b.Property<int>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<int>("AttendeeID")
                        .HasColumnType("int");

                    b.HasKey("ConferenceID", "AttendeeID");

                    b.HasIndex("AttendeeID");

                    b.ToTable("ConferenceAttendees");

                    b.HasData(
                        new
                        {
                            ConferenceID = 1001,
                            AttendeeID = 101
                        },
                        new
                        {
                            ConferenceID = 1001,
                            AttendeeID = 102
                        },
                        new
                        {
                            ConferenceID = 1002,
                            AttendeeID = 103
                        },
                        new
                        {
                            ConferenceID = 1002,
                            AttendeeID = 104
                        },
                        new
                        {
                            ConferenceID = 1002,
                            AttendeeID = 105
                        },
                        new
                        {
                            ConferenceID = 1001,
                            AttendeeID = 106
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.ConferenceVenue", b =>
                {
                    b.Property<int>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<int>("VenueID")
                        .HasColumnType("int");

                    b.HasKey("ConferenceID", "VenueID");

                    b.HasIndex("VenueID");

                    b.ToTable("ConferenceVenues");

                    b.HasData(
                        new
                        {
                            ConferenceID = 1001,
                            VenueID = 10
                        },
                        new
                        {
                            ConferenceID = 1002,
                            VenueID = 11
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Contact", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Contacts");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Contact");
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

            modelBuilder.Entity("ConferenceManager.Models.Entities.EventAttendee", b =>
                {
                    b.Property<int>("EventID")
                        .HasColumnType("int");

                    b.Property<int>("AttendeeID")
                        .HasColumnType("int");

                    b.HasKey("EventID", "AttendeeID");

                    b.HasIndex("AttendeeID");

                    b.ToTable("EventAttendees");

                    b.HasData(
                        new
                        {
                            EventID = 101,
                            AttendeeID = 101
                        },
                        new
                        {
                            EventID = 102,
                            AttendeeID = 102
                        },
                        new
                        {
                            EventID = 103,
                            AttendeeID = 103
                        },
                        new
                        {
                            EventID = 101,
                            AttendeeID = 104
                        },
                        new
                        {
                            EventID = 102,
                            AttendeeID = 104
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Room", b =>
                {
                    b.Property<int>("ID")
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

                    b.HasKey("ID");

                    b.HasIndex("VenueID");

                    b.ToTable("Rooms");

                    b.HasData(
                        new
                        {
                            ID = 1010,
                            CrescentRoundCapacity = 65,
                            Name = "101",
                            SchoolRoomCapacity = 50,
                            TheatreCapacity = 100,
                            VenueID = 10
                        },
                        new
                        {
                            ID = 1011,
                            CrescentRoundCapacity = 65,
                            Name = "201",
                            SchoolRoomCapacity = 50,
                            TheatreCapacity = 100,
                            VenueID = 10
                        },
                        new
                        {
                            ID = 1012,
                            CrescentRoundCapacity = 650,
                            Name = "Mile High Ballroom",
                            SchoolRoomCapacity = 500,
                            TheatreCapacity = 1000,
                            VenueID = 10
                        },
                        new
                        {
                            ID = 1013,
                            CrescentRoundCapacity = 350,
                            Name = "Marco Polo Ballroom",
                            SchoolRoomCapacity = 250,
                            TheatreCapacity = 500,
                            VenueID = 11
                        },
                        new
                        {
                            ID = 1014,
                            CrescentRoundCapacity = 65,
                            Name = "Red Rover",
                            SchoolRoomCapacity = 50,
                            TheatreCapacity = 100,
                            VenueID = 11
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Venue", b =>
                {
                    b.Property<int>("ID")
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

                    b.HasKey("ID");

                    b.ToTable("Venues");

                    b.HasData(
                        new
                        {
                            ID = 10,
                            Address1 = "700 14th St",
                            City = "Denver",
                            Name = "Colorado Convention Center",
                            Phone = "303-303-0000",
                            PostalCode = "80202",
                            State = "CO"
                        },
                        new
                        {
                            ID = 11,
                            Address1 = "1405 Curtis St",
                            City = "Denver",
                            Name = "The Curtis Hotel",
                            Phone = "720-303-0000",
                            PostalCode = "80202",
                            State = "CO"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Attendee", b =>
                {
                    b.HasBaseType("ConferenceManager.Models.Entities.Contact");

                    b.Property<DateTime>("DateRegistered")
                        .HasColumnType("datetime2");

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

                    b.HasDiscriminator().HasValue("Attendee");

                    b.HasData(
                        new
                        {
                            ID = 103,
                            Email = "cherrith@marritimelaw.com",
                            Phone = "303-303-3032",
                            DateRegistered = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Cherrith",
                            IsPresenter = false,
                            IsStaff = false,
                            LastName = "Goodstory"
                        },
                        new
                        {
                            ID = 106,
                            Email = "bill@compuserve.com",
                            Phone = "303-303-3035",
                            DateRegistered = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Bill",
                            IsPresenter = false,
                            IsStaff = false,
                            LastName = "Smith"
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Presentation", b =>
                {
                    b.HasBaseType("ConferenceManager.Models.Entities.Event");

                    b.Property<int>("PresenterID")
                        .HasColumnType("int");

                    b.HasIndex("PresenterID");

                    b.HasDiscriminator().HasValue("Presentation");

                    b.HasData(
                        new
                        {
                            ID = 101,
                            ConferenceID = 1001,
                            Description = "Hear our president discuss the role of professional organizations in the 21st century",
                            EndTime = new DateTime(2021, 4, 25, 23, 58, 27, 632, DateTimeKind.Local).AddTicks(6110),
                            Name = "Professional Associations in the 21st century",
                            RoomID = 1010,
                            StartTime = new DateTime(2021, 4, 25, 21, 58, 27, 632, DateTimeKind.Local).AddTicks(5714),
                            PresenterID = 102
                        },
                        new
                        {
                            ID = 102,
                            ConferenceID = 1001,
                            Description = "Join a discussion about the various services a professional organization can offer it's members",
                            EndTime = new DateTime(2021, 4, 26, 23, 58, 27, 632, DateTimeKind.Local).AddTicks(6580),
                            Name = "Member Services",
                            RoomID = 1011,
                            StartTime = new DateTime(2021, 4, 26, 21, 58, 27, 632, DateTimeKind.Local).AddTicks(6564),
                            PresenterID = 101
                        },
                        new
                        {
                            ID = 103,
                            ConferenceID = 1002,
                            Description = "Learn about the proper application of our tunnel paint in dry arid climates.",
                            EndTime = new DateTime(2021, 4, 26, 23, 58, 27, 632, DateTimeKind.Local).AddTicks(6592),
                            Name = "Paint Application in Aird Climates",
                            RoomID = 1011,
                            StartTime = new DateTime(2021, 4, 26, 21, 58, 27, 632, DateTimeKind.Local).AddTicks(6589),
                            PresenterID = 104
                        },
                        new
                        {
                            ID = 104,
                            ConferenceID = 1002,
                            Description = "Our rockets aren't just for hunting! Come hear about Acme's plans to land the first coyote on the moon",
                            EndTime = new DateTime(2021, 4, 26, 23, 58, 27, 632, DateTimeKind.Local).AddTicks(6597),
                            Name = "Acme Orbital",
                            RoomID = 1013,
                            StartTime = new DateTime(2021, 4, 26, 21, 58, 27, 632, DateTimeKind.Local).AddTicks(6595),
                            PresenterID = 105
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Presenter", b =>
                {
                    b.HasBaseType("ConferenceManager.Models.Entities.Attendee");

                    b.HasDiscriminator().HasValue("Presenter");

                    b.HasData(
                        new
                        {
                            ID = 101,
                            Email = "steve@juno.com",
                            Phone = "303-303-3030",
                            DateRegistered = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Steve",
                            IsPresenter = true,
                            IsStaff = false,
                            LastName = "Johnson"
                        },
                        new
                        {
                            ID = 102,
                            Email = "dave@juno.com",
                            Phone = "303-303-3031",
                            DateRegistered = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Dave",
                            IsPresenter = true,
                            IsStaff = false,
                            LastName = "Jackson"
                        },
                        new
                        {
                            ID = 104,
                            Email = "friz@wb.com",
                            Phone = "303-303-3033",
                            DateRegistered = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Friz",
                            IsPresenter = true,
                            IsStaff = false,
                            LastName = "Freeling"
                        },
                        new
                        {
                            ID = 105,
                            Email = "wil@varoom.com",
                            Phone = "303-303-3034",
                            DateRegistered = new DateTime(2021, 4, 24, 0, 0, 0, 0, DateTimeKind.Local),
                            FirstName = "Wile E",
                            IsPresenter = true,
                            IsStaff = false,
                            LastName = "Coyote"
                        });
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.ConferenceAttendee", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.Attendee", "Attendee")
                        .WithMany("ConferenceAttendees")
                        .HasForeignKey("AttendeeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Entities.Conference", "Conference")
                        .WithMany("ConferenceAttendees")
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.ConferenceVenue", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.Conference", "Conference")
                        .WithMany("ConferenceVenues")
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Entities.Venue", "Venue")
                        .WithMany("ConferenceVenues")
                        .HasForeignKey("VenueID")
                        .OnDelete(DeleteBehavior.Restrict)
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
                        .WithMany("Events")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.EventAttendee", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.Entities.Presentation", b =>
                {
                    b.HasOne("ConferenceManager.Models.Entities.Presenter", "Presenter")
                        .WithMany("Presentations")
                        .HasForeignKey("PresenterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

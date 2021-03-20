﻿// <auto-generated />
using System;
using ConferencePlanner.DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConferencePlanner.Migrations
{
    [DbContext(typeof(ConferencePlannerContext))]
    [Migration("20210320052725_Inital")]
    partial class Inital
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConferencePlanner.Models.Attendee", b =>
                {
                    b.Property<int>("AttendeeID")
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

                    b.HasKey("AttendeeID");

                    b.ToTable("Attendees");
                });

            modelBuilder.Entity("ConferencePlanner.Models.Conference", b =>
                {
                    b.Property<int>("ConferenceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                });

            modelBuilder.Entity("ConferencePlanner.Models.ConferenceAttendees", b =>
                {
                    b.Property<int>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<int>("AttendeeID")
                        .HasColumnType("int");

                    b.HasKey("ConferenceID", "AttendeeID");

                    b.HasIndex("AttendeeID");

                    b.ToTable("ConferenceAttendees");
                });

            modelBuilder.Entity("ConferencePlanner.Models.ConferenceVenues", b =>
                {
                    b.Property<int>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<int>("VenueID")
                        .HasColumnType("int");

                    b.HasKey("ConferenceID", "VenueID");

                    b.HasIndex("VenueID");

                    b.ToTable("ConferenceVenues");
                });

            modelBuilder.Entity("ConferencePlanner.Models.Presentation", b =>
                {
                    b.Property<int>("PresentationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Name")
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<int>("RoomID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("PresentationID");

                    b.HasIndex("ConferenceID");

                    b.HasIndex("RoomID");

                    b.ToTable("Presentations");
                });

            modelBuilder.Entity("ConferencePlanner.Models.PresentationAttendees", b =>
                {
                    b.Property<int>("PresentationID")
                        .HasColumnType("int");

                    b.Property<int>("AttendeeID")
                        .HasColumnType("int");

                    b.HasKey("PresentationID", "AttendeeID");

                    b.HasIndex("AttendeeID");

                    b.ToTable("PresentationAttendees");
                });

            modelBuilder.Entity("ConferencePlanner.Models.Room", b =>
                {
                    b.Property<int>("RoomID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CrescentRoundCpacity")
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
                });

            modelBuilder.Entity("ConferencePlanner.Models.Venue", b =>
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

                    b.Property<int>("PostalCode")
                        .HasColumnType("int")
                        .HasMaxLength(20);

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(2)")
                        .HasMaxLength(2);

                    b.HasKey("VenueID");

                    b.ToTable("Venue");
                });

            modelBuilder.Entity("ConferencePlanner.Models.ConferenceAttendees", b =>
                {
                    b.HasOne("ConferencePlanner.Models.Attendee", "Attendee")
                        .WithMany("ConferenceAttendees")
                        .HasForeignKey("AttendeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferencePlanner.Models.Conference", "Conference")
                        .WithMany("ConferenceAttendees")
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferencePlanner.Models.ConferenceVenues", b =>
                {
                    b.HasOne("ConferencePlanner.Models.Conference", "Conference")
                        .WithMany("ConferenceVenues")
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferencePlanner.Models.Venue", "Venue")
                        .WithMany("ConferenceVenues")
                        .HasForeignKey("VenueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferencePlanner.Models.Presentation", b =>
                {
                    b.HasOne("ConferencePlanner.Models.Conference", "Conference")
                        .WithMany()
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferencePlanner.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferencePlanner.Models.PresentationAttendees", b =>
                {
                    b.HasOne("ConferencePlanner.Models.Attendee", "Attendee")
                        .WithMany("PresentationAttendees")
                        .HasForeignKey("AttendeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferencePlanner.Models.Presentation", "Presentation")
                        .WithMany("PresentationAttendees")
                        .HasForeignKey("PresentationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferencePlanner.Models.Room", b =>
                {
                    b.HasOne("ConferencePlanner.Models.Venue", null)
                        .WithMany("Rooms")
                        .HasForeignKey("VenueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
﻿// <auto-generated />
using System;
using ConferenceManager.DataLayer;
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
                .HasAnnotation("ProductVersion", "3.1.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConferenceManager.Models.Attendee", b =>
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
                });

            modelBuilder.Entity("ConferenceManager.Models.Conference", b =>
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
                });

            modelBuilder.Entity("ConferenceManager.Models.ConferenceAttendees", b =>
                {
                    b.Property<int>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.HasKey("ConferenceID", "ID");

                    b.HasIndex("ID");

                    b.ToTable("ConferenceAttendees");
                });

            modelBuilder.Entity("ConferenceManager.Models.ConferenceVenues", b =>
                {
                    b.Property<int>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<int>("VenueID")
                        .HasColumnType("int");

                    b.HasKey("ConferenceID", "VenueID");

                    b.HasIndex("VenueID");

                    b.ToTable("ConferenceVenues");
                });

            modelBuilder.Entity("ConferenceManager.Models.Presentation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<int>("ConferenceID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

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

                    b.HasIndex("ID");

                    b.HasIndex("ConferenceID");

                    b.HasIndex("RoomID");

                    b.ToTable("Presentations");
                });

            modelBuilder.Entity("ConferenceManager.Models.PresentationAttendees", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.HasKey("ID", "ID");

                    b.HasIndex("ID");

                    b.ToTable("PresentationAttendees");
                });

            modelBuilder.Entity("ConferenceManager.Models.Room", b =>
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
                });

            modelBuilder.Entity("ConferenceManager.Models.Venue", b =>
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

                    b.ToTable("Venue");
                });

            modelBuilder.Entity("ConferenceManager.Models.ConferenceAttendees", b =>
                {
                    b.HasOne("ConferenceManager.Models.Attendee", "Attendee")
                        .WithMany("ConferenceAttendees")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Conference", "Conference")
                        .WithMany("ConferenceAttendees")
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.ConferenceVenues", b =>
                {
                    b.HasOne("ConferenceManager.Models.Conference", "Conference")
                        .WithMany("ConferenceVenues")
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Venue", "Venue")
                        .WithMany("ConferenceVenues")
                        .HasForeignKey("VenueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.Presentation", b =>
                {
                    b.HasOne("ConferenceManager.Models.Attendee", "Attendee")
                        .WithMany()
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Conference", "Conference")
                        .WithMany()
                        .HasForeignKey("ConferenceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Room", "Room")
                        .WithMany("Presentations")
                        .HasForeignKey("RoomID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.PresentationAttendees", b =>
                {
                    b.HasOne("ConferenceManager.Models.Attendee", "Attendee")
                        .WithMany("PresentationAttendees")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConferenceManager.Models.Presentation", "Presentation")
                        .WithMany("PresentationAttendees")
                        .HasForeignKey("ID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("ConferenceManager.Models.Room", b =>
                {
                    b.HasOne("ConferenceManager.Models.Venue", "Venue")
                        .WithMany("Rooms")
                        .HasForeignKey("VenueID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConferenceManager.Services.DataAccess.SeedData
{
    public class AttendeeSeedData : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.HasData(
            new Attendee
            {
                ID = 103,
                FirstName = "Cherrith",
                LastName = "Goodstory",
                Phone = "303-303-3032",
                Email = "cherrith@marritimelaw.com",
                IsPresenter = false,
                IsStaff = false,
                DateRegistered = DateTime.Today
            },
            new Attendee
            {
                ID = 106,
                FirstName = "Bill",
                LastName = "Smith",
                Phone = "303-303-3035",
                Email = "bill@compuserve.com",
                IsPresenter = false,
                IsStaff = false,
                DateRegistered = DateTime.Today
            });
        }
    }
}

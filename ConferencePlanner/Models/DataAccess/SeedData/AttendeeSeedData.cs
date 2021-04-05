using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConferenceManager.Models.DataAccess.SeedData
{
    public class AttendeeSeedData : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.HasData(new Attendee
            {
                ID = 101,
                FirstName = "Steve",
                LastName = "Johnson",
                Phone = "303-303-3030",
                Email = "steve@juno.com",
                IsPresenter = true,
                IsStaff = false,
                DateRegistered = DateTime.Today
            },
            new Attendee
            {
                ID = 102,
                FirstName = "Dave",
                LastName = "Jackson",
                Phone = "303-303-3031",
                Email = "dave@juno.com",
                IsPresenter = true,
                IsStaff = false,
                DateRegistered = DateTime.Today
            },
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
                ID = 104,
                FirstName = "Friz",
                LastName = "Freeling",
                Phone = "303-303-3033",
                Email = "friz@wb.com",
                IsPresenter = true,
                IsStaff = false,
                DateRegistered = DateTime.Today
            },
            new Attendee
            {
                ID = 105,
                FirstName = "Wile E",
                LastName = "Coyote",
                Phone = "303-303-3034",
                Email = "wil@varoom.com",
                IsPresenter = true,
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

using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ConferenceManager.Services.DataAccess.SeedData
{
    public class PresenterSeedData : IEntityTypeConfiguration<Presenter>
    {
        public void Configure(EntityTypeBuilder<Presenter> builder)
        {
            builder.HasData(new Presenter
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
            new Presenter
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
            new Presenter
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
            new Presenter
            {
                ID = 105,
                FirstName = "Wile E",
                LastName = "Coyote",
                Phone = "303-303-3034",
                Email = "wil@varoom.com",
                IsPresenter = true,
                IsStaff = false,
                DateRegistered = DateTime.Today
            });
        }
    }
}
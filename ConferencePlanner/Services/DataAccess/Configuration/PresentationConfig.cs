using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.Configuration
{
    public class PresentationConfig : IEntityTypeConfiguration<Presentation>
    {
        public void Configure(EntityTypeBuilder<Presentation> builder)
        {
            builder.HasKey(cv => new { cv.ID });

            builder.HasOne(cv => cv.Presenter)
                .WithMany(c => c.Presentations)
                .HasForeignKey(cv => cv.PresenterID)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

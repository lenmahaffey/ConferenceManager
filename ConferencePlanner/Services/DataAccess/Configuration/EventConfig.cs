using ConferenceManager.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConferenceManager.Services.DataAccess.Configuration
{
    public class EventConfig : IEntityTypeConfiguration<Event>
    {
        public void Configure(EntityTypeBuilder<Event> builder)
        {
            builder.HasKey(e => new { e.ID });

            builder.HasOne(e => e.Room)
                .WithMany(r => r.Events)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

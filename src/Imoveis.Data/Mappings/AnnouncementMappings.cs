using Imoveis.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Imoveis.Data.Mappings
{
    public class AnnouncementMappings : IEntityConfiguraration<Announcement>
    {

        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder.ToTable("Announcements");
            builder.HasKey(a => a.AnnouncementId);
            builder.Property(a => a.Bathroom);
            builder.Property(a => a.Bedroom);
            builder.Property(a => a.CondominiumValue);
            builder.Property(a => a.Description);
            builder.Property(a => a.Suite);
            builder.Property(a => a.Iptu);
            builder.Property(a => a.Vacancy);
            builder.Property(a => a.UsefulArea);
            builder.Property(a => a.Value);
            builder.HasOne(u => u.Immobile);
                     

            builder.ToTable("BankStatements");
        }

    }
}

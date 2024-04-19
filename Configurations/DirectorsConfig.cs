using EfCoreTasks1.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTasks1.Configurations
{
    public class DirectorsConfig : IEntityTypeConfiguration<Directors>
    {
        public void Configure(EntityTypeBuilder<Directors> builder)
        {
            builder.HasMany(e => e.Movies).WithOne(x =>
            x.Director).HasForeignKey(x => x.DirectorId);
        }
    }
}

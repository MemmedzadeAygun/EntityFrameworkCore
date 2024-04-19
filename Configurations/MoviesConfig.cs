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
    public class MoviesConfig : IEntityTypeConfiguration<Movies>
    {
        public void Configure(EntityTypeBuilder<Movies> builder)
        {
            builder.HasMany(e => e.MovieSubtitles).WithOne(x => 
            x.Movies).HasForeignKey(x => x.MoviesId);
        }
    }
}

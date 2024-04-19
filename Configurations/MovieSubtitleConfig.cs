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
    public class MovieSubtitleConfig : IEntityTypeConfiguration<MovieSubtitle>
    {
        public void Configure(EntityTypeBuilder<MovieSubtitle> builder)
        {
            builder.HasKey(x => new { x.MoviesId, x.SubtitlesId });
        }
    }

}


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
    public class SubtitleConfig : IEntityTypeConfiguration<Subtitles>
    {
        public void Configure(EntityTypeBuilder<Subtitles> builder)
        {
            builder.HasMany(x => x.MovieSubtitles).WithOne(e =>
            e.Subtitles).HasForeignKey(e => e.SubtitlesId);
        }
    }
}

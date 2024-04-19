using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTasks1.Classes
{
    public class MovieSubtitle
    {
        
        public int MoviesId { get; set; }
        public Movies Movies { get; set; }

        public int SubtitlesId { get; set; }
        public Subtitles Subtitles { get; set; }
    }
}

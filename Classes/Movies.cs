using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTasks1.Classes
{
    public class Movies
    {
        public int Id { get; set; }
        public string MovieName { get; set; }
        public DateTime MovieReleaseDate { get; set; }
        public string Description { get; set; }

        public int DirectorId { get; set; }
        public Directors Director { get; set; }
        public MoviesImdbDetail MoviesImdbDetails { get; set; }
        public ICollection<MovieSubtitle> MovieSubtitles { get; set; }
    }
}

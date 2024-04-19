using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreTasks1.Classes
{
    public class MoviesImdbDetail
    {
        public int Id { get; set; }
        public int ImdbPoint { get; set; }
        public int MovieId { get; set; }
        public Movies Movie { get; set; }
    }
}

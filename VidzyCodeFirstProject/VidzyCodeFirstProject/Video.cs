using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VidzyCodeFirstProject
{
    public class Video
    {
        public int id {  get; set; }
        public string Name { get; set; }
        public DateTime Releasedate { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public Classification Classification { get; set; }
    }
}

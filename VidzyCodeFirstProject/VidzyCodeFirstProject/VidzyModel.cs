using System;
using System.Data.Entity;
using System.Linq;

namespace VidzyCodeFirstProject
{
    public class VidzyModel : DbContext
    {
        
        public VidzyModel()
        
        {
        }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

      
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
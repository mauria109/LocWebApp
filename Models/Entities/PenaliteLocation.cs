using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "penalite_location")]
    public class PenaliteLocation
    {
        public PenaliteLocation()
        {
        }


        public PenaliteLocation(int id, int article, int location)
        {
            Id = id;
            Article = article;
            Location = location;
        }
        
        

        [Column (IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "id_art")]
        public int Article {get;set;}

        [Column (Name = "id_loc")]
        public int Location {get;set;}
        
        
        public class PenLocDbContext : DbContext
        {
            public DbSet<PenaliteLocation> PenaliteLocations {get;set;}
        }
    }
}
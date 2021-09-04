using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "reserver")]
    public class Reserver
    {
        public Reserver() {
            
        }


        public Reserver(int id, int article, int nombre, int reservation)
        {
            Id = id;
            Article = article;
            Nombre = nombre;
            Reservation = reservation;
        }

        [Column (IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "id_art")]
        public int Article {get;set;}

        [Column (Name = "id_res")]
        public int Reservation {get;set;}

        [Column (Name = "nombre")]
        public int Nombre {get;set;}
        
        public class ReserverDbContext : DbContext
        {
            public DbSet<Reserver> Reservers {get;set;}
        }
    }
}
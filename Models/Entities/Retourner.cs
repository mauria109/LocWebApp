using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "retourner")]
    public class Retourner
    {
        public Retourner()
        {
        }

        public Retourner(int id, int retour, int location, int article, int nombre)
        {
            Id = id;
            Retour = retour;
            Location = location;
            Article = article;
            Nombre = nombre;
        }

        [Column (IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "id_ret")]
        public int Retour {get;set;}

        [Column (Name = "id_loc")]
        public int Location {get;set;}

        [Column (Name = "id_art")]
        public int Article {get;set;}

        [Column (Name = "nombre")]
        public int Nombre {get;set;}
        
        public class RetournerDbContext : DbContext
        {
            public DbSet<Retourner> Retourners {get;set;}
        }
    }
}
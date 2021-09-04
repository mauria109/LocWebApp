using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "client")]
    public class Client
    {
        public Client()
        {
        }

        public Client(int id, string nom, string prenom, int tel, string ci)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Tel = tel;
            Ci = ci;
        }


        [Column (IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "nom_cli")]
        public string Nom {get;set;}

        [Column (Name = "prenom_cli")]
        public string Prenom {get;set;}

        [Column (Name = "telephone")]
        public int Tel {get;set;}

        [Column (Name = "numero_CNI")]
        public string Ci {get;set;}
        
        public class ClientDbContext : DbContext
        {
            public DbSet<Client> Clients {get;set;}
        }
    }
}
using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "user")]
    public class User
    {
        [Column (IsPrimaryKey = true)]
        public int IdUsr {get;set;}

        [Column (Name = "nom_usr")]
        public string NomUsr {get;set;}

        [Column (Name = "prenom_usr")]
        public string PrenomUsr {get;set;}

        [Column (Name = "login")]
        public string LoginUsr {get;set;}

        [Column (Name = "pwd")]
        public string PwdUsr {get;set;}

        [Column (Name = "droit")]
        public string DroitUsr {get;set;}
        
        public User()
        {
        }

        public User(int idUsr, string nomUsr, string prenomUsr, string loginUsr, string pwdUsr, string droitUsr) {
            IdUsr = idUsr;
            NomUsr = nomUsr;
            PrenomUsr = prenomUsr;
            LoginUsr = loginUsr;
            PwdUsr = pwdUsr;
            DroitUsr = droitUsr;
        }
        
        
        public class UserDbContext : DbContext
        {
            public DbSet<User> Users {get;set;}
        }
    }
}
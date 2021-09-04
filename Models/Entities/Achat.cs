using System;
using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "achat")]
    public class Achat
    {
        public Achat()
        {
        }


        public Achat(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }

        [Column(IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "date_ach")]
        public DateTime Date {get;set;}
        
        public class AchatDbContext : DbContext
        {
            public DbSet<Achat> Achats {get;set;}
        }
    }
}
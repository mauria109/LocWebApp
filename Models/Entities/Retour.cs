using System;
using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "retour")]
    public class Retour
    {
        public Retour()
        {
        }

        public Retour(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }

        [Column (IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "date_ret")]
        public DateTime Date {get;set;}
        
        
        public class RetourDbContext : DbContext
        {
            public DbSet<Retour> Retours {get;set;}
        }
    }
}
using System;
using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "penalite")]
    public class Penalite
    {
        public Penalite()
        {
        }

        public Penalite(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }

        [Column (IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "date_pen")]
        public DateTime Date {get;set;}
        
        
        public class PenDbContext : DbContext
        {
            public DbSet<Penalite> Pens {get;set;}
        }
    }
}
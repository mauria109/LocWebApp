using System;
using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "incident")]
    public class Incident
    {
        public Incident()
        {
        }

        public Incident(int id, DateTime date)
        {
            Id = id;
            Date = date;
        }

        [Column (IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "date_inc")]
        public DateTime Date {get;set;}
        
        public class IncDbContext : DbContext
        {
            public DbSet<Incident> Incidents {get;set;}
        }
    }
}
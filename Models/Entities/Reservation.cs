using System;
using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "reservation")]
    public class Reservation
    {
        public Reservation()
        {
        }

        public Reservation(int id, DateTime date, int client)
        {
            Id = id;
            Date = date;
            Client = client;
        }

        [Column (IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "date_res")]
        public DateTime Date {get;set;}

        [Column (Name = "id_cli")]
        public int Client {get;set;}
        
        public class ResDbContext : DbContext
        {
            public DbSet<Reservation> Reservations {get;set;}
        }
    }
}
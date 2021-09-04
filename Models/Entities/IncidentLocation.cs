using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "incident_location")]
    public class IncidentLocation
    {
        public IncidentLocation() {
            
        }

        public IncidentLocation(int id, int location, int achat, string typeIncident, int nombre, int incident)
        {
            Id = id;
            Location = location;
            Achat = achat;
            TypeIncident = typeIncident;
            Nombre = nombre;
            Incident = incident;
        }

        [Column(IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "id_inc")]
        public int Incident {get;set;}

        [Column (Name = "id_loc")]
        public int Location {get;set;}

        [Column (Name = "id_ach")]
        public int Achat {get;set;}

        [Column (Name = "type_inc")]
        public string TypeIncident {get;set;}

        [Column (Name = "nombre")]
        public int Nombre {get;set;}
        
        
        public class IncLocDbContext : DbContext
        {
            public DbSet<IncidentLocation> Incloc {get;set;}
        }
    }
}
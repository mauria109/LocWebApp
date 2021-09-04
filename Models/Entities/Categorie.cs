using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "categorie")]
    public class Categorie
    {
        public Categorie(int id, string label, string code)
        {
            Id = id;
            Label = label;
            Code = code;
        }
        
        public Categorie()
        {
        }


        [Column (IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "label_cat")]
        public string Label {get;set;}

        [Column (Name = "code_cat")]
        public string Code {get;set;}
        
        public class CategoryDbContext : DbContext
        {
            public DbSet<Categorie> Categories {get;set;}
        }
    }
}
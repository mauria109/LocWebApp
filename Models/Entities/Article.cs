using System.Data.Linq.Mapping;
using Microsoft.EntityFrameworkCore;

namespace LocWebApp.Models.Entities
{
    [Table (Name = "article")]
    public class Article
    {
        public Article()
        {
        }

        public Article(int id, string label, string description, float prix, int quantity, int categorie)
        {
            Id = id;
            Label = label;
            Description = description;
            Prix = prix;
            Quantity = quantity;
            Categorie = categorie;
        }

        [Column (IsPrimaryKey = true)]
        public int Id {get;set;}

        [Column (Name = "libelle")]
        public string Label {get;set;}

        [Column (Name = "desc")]
        public string Description {get;set;}

        [Column (Name = "pu")]
        public float Prix {get;set;}

        [Column (Name = "quantite")]
        public int Quantity {get;set;}

        [Column (Name = "id_cat")]
        public int Categorie {get;set;}

        public class ArticleDbContext : DbContext
        {
            public DbSet<Article> Articles {get;set;}
        }
    }
}
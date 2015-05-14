namespace ProductsApp.Data_Object
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using ProductsApp.Models;

    public partial class ProductsContext : DbContext
    {
        public ProductsContext()
            : base("name=ProductsContext")
        {
        }

        public virtual DbSet<Product> Product { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

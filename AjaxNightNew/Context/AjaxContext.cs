using AjaxNightNew.Entities;
using Microsoft.EntityFrameworkCore;

namespace AjaxNightNew.Context
{
    public class AjaxContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=Anıl\\SQLEXPRESS;initial Catalog=AjaxNightDb;integrated Security=true");
        }

        public DbSet<Customer> Customers { get; set; }
    }
}

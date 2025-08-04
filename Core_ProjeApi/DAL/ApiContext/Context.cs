using Core_ProjeApi.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_ProjeApi.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-JT0HDA3C;database=WebProjeCwDB2;Integrated Security=True;");
        }

        public DbSet<Category> Categories { get; set; }
    }
}

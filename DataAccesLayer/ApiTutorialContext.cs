using ApiTutorial.Model.Domain;
using Microsoft.EntityFrameworkCore;

namespace ApiTutorial.DataAccesLayer
{
    public class ApiTutorialContext:DbContext
    {
        public ApiTutorialContext(DbContextOptions<ApiTutorialContext> options):base(options) { }

        public DbSet<Customers> customers { get; set; }
        
    }
}

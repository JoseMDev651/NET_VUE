using backend_tareas.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_tareas.Context
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {
            
        }
        public DbSet<Tarea> Tareas { get; set; }
    }
}

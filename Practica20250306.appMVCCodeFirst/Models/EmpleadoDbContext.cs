using Microsoft.EntityFrameworkCore;
namespace Practica20250306.appMVCCodeFirst.Models
{
    public class EmpleadoDbContext : DbContext {

        public EmpleadoDbContext(DbContextOptions<EmpleadoDbContext> options) : 
     base(options) { }

        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Alumno> Alumno { get; set; }
    }
}

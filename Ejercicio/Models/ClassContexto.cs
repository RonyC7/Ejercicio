using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio.Models
{
    public class ClassContexto: DbContext
    {
        public ClassContexto(DbContextOptions<ClassContexto> options):base(options)
        {

        }
        public DbSet<Cliente> clientes { get; set; }
        public DbSet<ClaseEjemplo> mascotas { get; set; }
    }
}

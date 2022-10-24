using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Ejercicio.Models
{
    public class Cliente
    { 
        
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
    }
}

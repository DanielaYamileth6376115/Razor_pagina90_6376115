using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Razor_Pag90.Models;

namespace Razor_Pag90.Data
{
    public class Razor_Pag90Context : DbContext
    {
        public Razor_Pag90Context (DbContextOptions<Razor_Pag90Context> options)
            : base(options)


        {
        }

        public DbSet<Razor_Pag90.Models.Empleado> Empleado { get; set; } = default!;

        public DbSet<Razor_Pag90.Models.Oficina> Oficina { get; set; } = default!;
        public DbSet<Razor_Pag90.Models.Cliente> Cliente { get; set; } = default!;
    }
}

using ControlIngresoGastos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlIngresoGastos.Data
{
    public class ApplicationDbContext :DbContext
    {
        public  ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Categoria> Categorias{ get; set; }

    }
}

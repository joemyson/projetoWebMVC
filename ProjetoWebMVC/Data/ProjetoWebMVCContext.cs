using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoWebMVC.Models;

namespace ProjetoWebMVC.Models
{
    public class ProjetoWebMVCContext : DbContext
    {
        public ProjetoWebMVCContext (DbContextOptions<ProjetoWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; }
        public DbSet<Vendedores> Vendedor { get; set; }
        public DbSet<RegistroVendas> RegistroVendas { get; set; }
        
    }
}

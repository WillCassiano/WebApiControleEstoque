using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiControleEstoque.Models;

namespace WebApiControleEstoque.Data
{
    public class AppEstoqueContext : DbContext
    {
        public AppEstoqueContext (DbContextOptions<AppEstoqueContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiControleEstoque.Models.Grupo> Grupo { get; set; }

        public DbSet<WebApiControleEstoque.Models.Produto> Produto { get; set; }
    }
}

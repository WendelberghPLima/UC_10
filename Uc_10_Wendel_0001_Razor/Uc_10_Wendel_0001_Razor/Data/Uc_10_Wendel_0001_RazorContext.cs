using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_0001_Razor.Models;

namespace Uc_10_Wendel_0001_Razor.Data
{
    public class Uc_10_Wendel_0001_RazorContext : DbContext
    {
        public Uc_10_Wendel_0001_RazorContext (DbContextOptions<Uc_10_Wendel_0001_RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Uc_10_Wendel_0001_Razor.Models.Carro> Carro { get; set; } = default!;
    }
}

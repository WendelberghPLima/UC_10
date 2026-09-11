using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_0003_Razor.Models;

namespace Uc_10_Wendel_0003_Razor.Data
{
    public class Uc_10_Wendel_0003_RazorContext : DbContext
    {
        public Uc_10_Wendel_0003_RazorContext (DbContextOptions<Uc_10_Wendel_0003_RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Uc_10_Wendel_0003_Razor.Models.jogo> jogo { get; set; } = default!;
    }
}

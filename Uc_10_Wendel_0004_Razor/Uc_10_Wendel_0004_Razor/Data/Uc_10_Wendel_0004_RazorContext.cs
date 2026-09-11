using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_0004_Razor.Models;

namespace Uc_10_Wendel_0004_Razor.Data
{
    public class Uc_10_Wendel_0004_RazorContext : DbContext
    {
        public Uc_10_Wendel_0004_RazorContext (DbContextOptions<Uc_10_Wendel_0004_RazorContext> options)
            : base(options)
        {
        }

        public DbSet<Uc_10_Wendel_0004_Razor.Models.filme> filme { get; set; } = default!;
    }
}

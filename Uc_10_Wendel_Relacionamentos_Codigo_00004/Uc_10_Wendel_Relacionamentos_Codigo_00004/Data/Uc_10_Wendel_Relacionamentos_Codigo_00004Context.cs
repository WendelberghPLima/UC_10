using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_Relacionamentos_Codigo_00004.Models;

namespace Uc_10_Wendel_Relacionamentos_Codigo_00004.Data
{
    public class Uc_10_Wendel_Relacionamentos_Codigo_00004Context : DbContext
    {
        public Uc_10_Wendel_Relacionamentos_Codigo_00004Context (DbContextOptions<Uc_10_Wendel_Relacionamentos_Codigo_00004Context> options)
            : base(options)
        {
        }

        public DbSet<Uc_10_Wendel_Relacionamentos_Codigo_00004.Models.Automovel> Automovel { get; set; } = default!;
        public DbSet<Uc_10_Wendel_Relacionamentos_Codigo_00004.Models.Marca> Marca { get; set; } = default!;
    }
}

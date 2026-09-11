using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_Relacionamentos_00002.Models;

namespace Uc_10_Wendel_Relacionamentos_00002.Data
{
    public class Uc_10_Wendel_Relacionamentos_00002Context : DbContext
    {
        public Uc_10_Wendel_Relacionamentos_00002Context (DbContextOptions<Uc_10_Wendel_Relacionamentos_00002Context> options)
            : base(options)
        {
        }

        public DbSet<Uc_10_Wendel_Relacionamentos_00002.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<Uc_10_Wendel_Relacionamentos_00002.Models.Pedido> Pedido { get; set; } = default!;
    }
}

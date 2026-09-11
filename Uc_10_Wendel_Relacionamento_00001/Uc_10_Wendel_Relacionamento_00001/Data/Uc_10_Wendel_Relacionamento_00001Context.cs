using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_Relacionamento_00001.Models;

namespace Uc_10_Wendel_Relacionamento_00001.Data
{
    public class Uc_10_Wendel_Relacionamento_00001Context : DbContext
    {
        public Uc_10_Wendel_Relacionamento_00001Context (DbContextOptions<Uc_10_Wendel_Relacionamento_00001Context> options)
            : base(options)
        {
        }

        public DbSet<Uc_10_Wendel_Relacionamento_00001.Models.Cidade> Cidade { get; set; } = default!;
        public DbSet<Uc_10_Wendel_Relacionamento_00001.Models.Cliente> Cliente { get; set; } = default!;
    }
}

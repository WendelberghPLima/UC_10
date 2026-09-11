using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Uc_10_Wendel_Relacionamentos_Codigo_00005.Models;

namespace Uc_10_Wendel_Relacionamentos_Descricao_00005.Data
{
    public class Uc_10_Wendel_Relacionamentos_Descricao_00005Context : DbContext
    {
        public Uc_10_Wendel_Relacionamentos_Descricao_00005Context (DbContextOptions<Uc_10_Wendel_Relacionamentos_Descricao_00005Context> options)
            : base(options)
        {
        }

        public DbSet<Uc_10_Wendel_Relacionamentos_Codigo_00005.Models.Aluno> Aluno { get; set; } = default!;
        public DbSet<Uc_10_Wendel_Relacionamentos_Codigo_00005.Models.Curso> Curso { get; set; } = default!;
    }
}

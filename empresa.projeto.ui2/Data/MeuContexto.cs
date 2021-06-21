using empresa.projeto.ui2.Tabela;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace empresa.projeto.ui2.Data
{
    public class MeuContexto : DbContext
    {
        public MeuContexto(DbContextOptions<MeuContexto> op) : base (op)
        {

        }

        public DbSet<Produto> Produto { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain
{
    public class Cliente : BaseDomain
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public virtual List<Locacao>? Locacoes { get; set; }

    }
}
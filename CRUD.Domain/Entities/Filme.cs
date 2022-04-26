using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain
{
    public class Filme : BaseDomain
    {
        public string? Titulo { get; set; }
        public int ClassificacaoIndicativa { get; set; }
        public TipoFilmeEnum Lancamento { get; set; }
        public virtual List<Locacao>? Locacoes { get; set; }
    }
}
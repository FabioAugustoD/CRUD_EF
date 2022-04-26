using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Domain
{
    public class Locacao : BaseDomain
    {
        public int ClienteId { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public int FilmeId { get; set; }
        public virtual Filme? Filme { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }

    }
}
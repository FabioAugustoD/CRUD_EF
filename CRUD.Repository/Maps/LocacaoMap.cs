using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using CRUD.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Repository
{
    public class LocacaoMap : BaseDomainMap<Locacao>
    {
        public LocacaoMap() : base() { }
        public override void Configure(EntityTypeBuilder<Locacao> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.ClienteId).IsRequired();
            builder.HasOne(x => x.Cliente).WithMany(x => x.Locacoes).HasForeignKey(x => x.ClienteId);

            builder.Property(x => x.FilmeId).IsRequired();
            builder.HasOne(x => x.Filme).WithMany(x => x.Locacoes).HasForeignKey(x => x.FilmeId);

            builder.Property(x => x.DataLocacao).IsRequired();
            builder.Property(x => x.DataDevolucao).IsRequired();
        }
    }
}
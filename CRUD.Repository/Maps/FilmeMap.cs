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
    public class FilmeMap : BaseDomainMap<Filme>
    {
        public FilmeMap() : base() { }
        public override void Configure(EntityTypeBuilder<Filme> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Titulo).HasMaxLength(100).IsRequired();
            builder.Property(x => x.ClassificacaoIndicativa).IsRequired();
            builder.Property(x => x.Lancamento).IsRequired();

        }
    }
}
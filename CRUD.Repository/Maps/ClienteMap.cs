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
    public class ClienteMap : BaseDomainMap<Cliente>
    {
        public ClienteMap() : base() { }
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Cpf).HasMaxLength(11).IsRequired();
            builder.Property(x => x.DataNascimento).IsRequired();
        }
    }
}
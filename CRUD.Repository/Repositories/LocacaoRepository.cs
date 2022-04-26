using CRUD.Domain;
using CRUD.Interface;
using System;
using System.Linq;

namespace CRUD.Repository
{
    public class LocacaoRepository : BaseRepository, ILocacaoRepository
    {
        public LocacaoRepository(AppDbContext dbContext) : base(dbContext)
        {
        }

        public dynamic Get()
        {
            var lista = DbContext.Locacoes
                .ToList();

            return lista;
        }

       
    }
}
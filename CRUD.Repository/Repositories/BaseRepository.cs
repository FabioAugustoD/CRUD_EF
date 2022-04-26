using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Repository
{
    public class BaseRepository
    {
        protected const int TamanhoPagina = 5;

        protected readonly AppDbContext DbContext;

        public BaseRepository(AppDbContext dbContext)
        {
            DbContext = dbContext;
        }
    }
}

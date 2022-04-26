using CRUD.Domain;
using CRUD.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace CRUD.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LocacaoController : ControllerBase
    {

      private readonly AppDbContext _context;

      public LocacaoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Locacao>>> Get()
        {
            return Ok(await _context.Locacoes.ToListAsync());
        }    

    }
}
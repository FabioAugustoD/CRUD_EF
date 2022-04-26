using CRUD.Interface;
using CRUD.Domain;
using Microsoft.AspNetCore.Mvc;
using System;

namespace CRUD.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LocacaoController : AppBaseController
    {
        public LocacaoController(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }

        [HttpGet]
        public dynamic Get()
        {
            var resp = GetService<ILocacaoRepository>().Get();
            return resp;
        }

       
    }
}
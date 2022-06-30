using CriptoApi.DAL;
using CriptoApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CriptoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoinsController : ControllerBase
    {
        private readonly ILogger<CoinsController> _logger;
        private Contexto _contexto;

        public CoinsController(ILogger<CoinsController> logger, Contexto contexto)
        {
            _logger = logger;
            _contexto = contexto;
        }

        [HttpGet(Name = "GetCoins")]
        public IEnumerable<Coins> Get()
        {
            return _contexto.Coins.AsNoTracking().ToList();
        }
    }
}
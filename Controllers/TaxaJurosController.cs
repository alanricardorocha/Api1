using Microsoft.AspNetCore.Mvc;

namespace Api1.Controllers
{
    public class TaxaJurosController : ControllerBase
    {

        [HttpGet("taxaJuros")]
        public decimal TaxaJuros()
        {
            return 0.01M;
        }
    }
}

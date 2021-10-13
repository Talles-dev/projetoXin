using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.XinWeb.Controllers
{
    [Route("[controller]")]
    public class SerieController : Controller
    {
        private IRepositorio<Serie>
        [HttpGet("")]
        public IActionResult Lista()
        {
            IList<SerieModel> series = new List<SerieModel>();
            return Ok(series);
        }

        [HttpPut("Id")]
        public IActionResult Atualiza(int Id, [FromBody] SerieModel model)
        {
            return Ok(model);
        }
        [HttpDelete("Id")]
        public IActionResult Delete(int Id)
        {
            return Ok(Id);
        }
        [HttpPost("")]
        public IActionResult Insere(int Id, [FromBody] SerieModel model)
        {
            return Ok(model);
        }
        [HttpPut("Id")]
        public IActionResult Consulta(int Id)
        {
            return Ok();
        }

    }
}

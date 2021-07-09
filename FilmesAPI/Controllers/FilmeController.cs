using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class FilmeController : ControllerBase
    {
        private static List<Filme> filmes = new List<Filme>();
        private static int id = 1;

        [HttpPost]
        public IActionResult AdicionaFilme([FromBody] Filme filme)
        {
            filmes.Add(filme);
            filme.Id = id++;
            return CreatedAtAction(nameof(RecuperaFilmeId), new { Id = filme.Id }, filme);
            
        }

        [HttpGet]
        public IActionResult RecuperaFilmes()
        {
            return Ok(filmes);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaFilmeId(int id)
        {
            var filme = filmes.FirstOrDefault(f => f.Id == id);
            if (filme is null)
                return NotFound();

            return Ok(filme);
        }
    }
}

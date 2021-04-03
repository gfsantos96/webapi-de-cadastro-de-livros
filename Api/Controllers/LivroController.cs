using Api.Data.Collections;
using Api.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LivroController : ControllerBase
    {
        Data.MongoDB _mongoDB;
        IMongoCollection<Livro> _livrosCollection;

        public LivroController(Data.MongoDB mongoDB)
        {
            _mongoDB = mongoDB;
            _livrosCollection = _mongoDB.DB.GetCollection<Livro>(typeof(Livro).Name.ToLower());
        }

        [HttpPost]
        public ActionResult SalvarLivro([FromBody] LivroDto dto)
        {
            var livro = new Livro(dto.Autor, dto.Titulo, dto.Sinopse, dto.Genero);

            _livrosCollection.InsertOne(livro);
            
            return StatusCode(201, "Livro adicionado!");
        }

        [HttpGet]
        public ActionResult ObterLivros()
        {
            var livros = _livrosCollection.Find(Builders<Livro>.Filter.Empty).ToList();
            
            return Ok(livros);
        }
    }
}

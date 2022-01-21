using fierbinteanu_backend.Entities;
using fierbinteanu_backend.Entities.DTOs;
using fierbinteanu_backend.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fierbinteanu_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorRepository _repository;
        public AutorController(IAutorRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAuthors()
        {
            var authors = await _repository.GetAllAuthorsWithAdress();

            var authorsToReturn = new List<AutorDTO>();

            foreach(var author in authors)
            {
                authorsToReturn.Add(new AutorDTO(author));
            }

            return Ok(authorsToReturn);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAuthorById(int id)
        {
            var author = await _repository.GetIdByAsync(id);
            return Ok(new AutorDTO(author));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthor(int id)
        {
            var author = await _repository.GetIdByAsync(id);
            if (author == null)
            {
                return NotFound("Author doesn't exist!");  
            }
            _repository.Delete(author);
            await _repository.SaveAsync();
            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateAuthor(CreateAutorDTO dto)
        {
            Autor newAutor = new Autor();
            newAutor.Nume = dto.Name;
            newAutor.YearOfBirth = dto.YearOfBirth;
            newAutor.Adresa = dto.Adresa;
            _repository.Create(newAutor);
            await _repository.SaveAsync();
            return Ok(new AutorDTO(newAutor));
        }
    }
}

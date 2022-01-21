using fierbinteanu_backend.Entities;
using fierbinteanu_backend.Entities.DTOs;
using fierbinteanu_backend.Repositories.CarteRepository;
using Microsoft.AspNetCore.Authorization;
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
    public class CarteController : ControllerBase
    {
        private readonly ICarteRepository _repository;
        public CarteController(ICarteRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            var books = await _repository.GetAllBooks();

            var booksToReturn = new List<CarteDTO>();

            foreach (var book in books)
            {
                booksToReturn.Add(new CarteDTO(book));
            }

            return Ok(booksToReturn);
        }
       
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteBook(int id)
        {
            var book = await _repository.GetIdByAsync(id);
            if (book == null)
            {
                return NotFound("Book doesn't exist!");
            }
            _repository.Delete(book);
            await _repository.SaveAsync();
            return NoContent();
        }


        [HttpPost]
        public async Task<IActionResult> CreateBook(CreateCarteDTO dto)
        {
            Carte newCarte = new Carte();
            newCarte.Name = dto.Name;
            newCarte.Autor = dto.Autor;
            newCarte.AutorNume = dto.AutorNume;
            _repository.Create(newCarte);
            await _repository.SaveAsync();
            return Ok(new CarteDTO(newCarte));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] Carte carte)
        {
            var books = await _repository.GetAllBooks();
            var booksIndex = books.FindIndex((Carte _book) => _book.Id.Equals(carte.Id));
            books[booksIndex] = carte;
            return Ok(books);
        }
        
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjetoAutoMapper.API.Application.InputModels;
using ProjetoAutoMapper.API.Application.Services.Interfaces;

namespace ProjetoAutoMapper.API.Controllers
{
    [Route("/person")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet("{Id}")]
        // GET: PersonController
        public async Task<ActionResult> GetById([FromRoute] int Id)
        {
            var person = await _personService.GetById(Id);
            return Ok(person);
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreatePersonInputModel inputModel)
        {
            var id = _personService.CreatePerson(inputModel);
            return Ok(id);
        }

    }
}

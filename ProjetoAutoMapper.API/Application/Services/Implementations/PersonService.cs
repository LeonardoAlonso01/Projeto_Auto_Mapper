using AutoMapper;
using ProjetoAutoMapper.API.Application.InputModels;
using ProjetoAutoMapper.API.Application.Services.Interfaces;
using ProjetoAutoMapper.API.Application.ViewModels;
using ProjetoAutoMapper.API.Domain.Entities;

namespace ProjetoAutoMapper.API.Application.Services.Implementations
{
    public class PersonService : IPersonService
    {
        private readonly IMapper _mapper;

        public PersonService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<int> CreatePerson(CreatePersonInputModel person)
        {
            var newPerson = _mapper.Map<Person>(person);
            return newPerson.Id;
        }

        public async Task<PersonViewModel> GetById(int id)
        {
            //var person = _personRepository.GetById(id);
            var person = new Person(1, "Leonardo", "", "Alonso", "");
            var personViewModel = _mapper.Map<PersonViewModel>(person);
            return personViewModel;
        }
    }
}

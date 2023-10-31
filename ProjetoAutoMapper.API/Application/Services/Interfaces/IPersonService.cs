using ProjetoAutoMapper.API.Application.InputModels;
using ProjetoAutoMapper.API.Application.ViewModels;
using ProjetoAutoMapper.API.Domain.Entities;

namespace ProjetoAutoMapper.API.Application.Services.Interfaces
{
    public interface IPersonService
    {
        Task<PersonViewModel> GetById(int id);
        Task<int> CreatePerson(CreatePersonInputModel person);
    }
}

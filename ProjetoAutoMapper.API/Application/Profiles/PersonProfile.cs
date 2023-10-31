using AutoMapper;
using ProjetoAutoMapper.API.Application.InputModels;
using ProjetoAutoMapper.API.Application.ViewModels;
using ProjetoAutoMapper.API.Domain.Entities;

namespace ProjetoAutoMapper.API.Application.Profiles
{
    public class PersonProfile: Profile
    {
        public PersonProfile()
        {
            CreateMap<CreatePersonInputModel, Person>();
            CreateMap<Person, PersonViewModel>();
        }
    }
}

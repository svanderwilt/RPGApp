
using AutoMapper;
using RPGApp.Dtos.Character;
using RPGApp.Models;

namespace RPGApp
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }
    }
}
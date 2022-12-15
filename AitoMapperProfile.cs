using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotnet7RpgGame.Dtos.Character;

namespace Dotnet7RpgGame
{
    public class AitoMapperProfile : Profile
    {
        public AitoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<UpdateCharacterDto, Character>();
        }
    }
}
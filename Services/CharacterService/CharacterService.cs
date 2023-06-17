using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Dtos.Character;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
            private static List<Character> characters = new List<Character> {
            new Character(),
            new Character {Id= 1, Name = "Sam"}
        };
        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {   
            characters.Add(newCharacter);
            return new ServiceResponse<List<GetCharacterDto>>{Data = characters};
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {

           return new ServiceResponse<List<GetCharacterDto>>{Data = characters};
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            var character = characters.FirstOrDefault(c => c.Id == id);
            
            return new ServiceResponse<GetCharacterDto>{Data = character};
        }
    }
}
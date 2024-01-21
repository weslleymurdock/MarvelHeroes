using MarvelHeroes.SDK.Model;
using Paging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;


namespace MarvelHeroes.Infrastructure.Interfaces
{
    public interface ICharacterService
    {
        Task<PaginationSet<Character>> GetPagedCharactersAsync(PagingInfo pagingInfo);
        List<Character> GetCharacters(string filter = "", int? limit = 0,int? offset = 0);
    }
}

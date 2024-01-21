using Paging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarvelHeroes.SDK.Api;
using MarvelHeroes.SDK.Model; 
using System;
using RestSharp;
using MarvelHeroes.Infrastructure.Interfaces; 
using Newtonsoft.Json; 

namespace MarvelHeroes.Infrastructure.Services
{
    public class CharacterServiceStub : ICharacterService
    {
        private readonly MarvelPublicApi _marvelAPI;
        private List<Character> _characteres;
        public CharacterServiceStub(MarvelPublicApi api)
        {
            this._marvelAPI = api;
            this._characteres = GetCharacters(null, null, 0);
        }

        public Task<PaginationSet<Character>> GetPagedCharactersAsync(PagingInfo pagingInfo)
        {
            // In a real-world implementation this implementation of ICharacterService
            // would send the PagingInfo object to the backend where the database is
            // performing searching, sorting, grouping and paging.
            // 
            // --> Use Paging.Queryable NuGet package for any .NET / EntityFramework-based backends
            var skip = (pagingInfo.CurrentPage - 1) * pagingInfo.ItemsPerPage;
            var take = pagingInfo.ItemsPerPage; 
            var queryable = this._characteres.Skip(skip).Take(take);

            var pagingSet = new PaginationSet<Character>(pagingInfo, queryable, this._characteres.Count, this._characteres.Count);
            
            return Task.FromResult(pagingSet);
        }

        public List<Character> GetCharacters(string filter = null, int? limit = 0, int? offset = 0)
        {
            IRestResponse response = _marvelAPI.GetCharacters(null,
               filter, 
               default,
               null, //comics
               null, //series
               null, //events
               null, //stories
               null, //orderby
               limit,
               offset);

            if (response is null || response is default(IRestResponse))
            {
                throw new Exception("Empty response");
            }

            if (!response.IsSuccessful)
            {
                throw new Exception("Failed request");
            }

            CharacterDataWrapper wrapper = JsonConvert.DeserializeObject<CharacterDataWrapper>(response.Content);
            
            return wrapper.Data.Results;
        }
    }
}
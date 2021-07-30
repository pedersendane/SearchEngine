using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SearchEngine.Data;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using SearchEngine.Models;
using System.Linq;

namespace SearchEngine.Services
{
    public class HistoryDataAccessService 
    {
        //Props
        private readonly ApplicationDbContext _applicationDbContext;
        
        //Constructor
        public HistoryDataAccessService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //Meth-Heads
        public List<SearchHistory> GetAllUserSearches(string id)
        {
            var searches = _applicationDbContext.Searches.Where(x => x.UserId.Equals(id));

            return searches.ToList();
        }

        public async Task<bool> InsertSearchHistoryAsync(SearchHistory search)
        {
            await _applicationDbContext.Searches.AddAsync(search);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        public async Task<SearchHistory> GetLastSearch(int id)
        {
            SearchHistory search = await _applicationDbContext.Searches.FirstOrDefaultAsync(c => c.SearchId.Equals(id));
            return search;
        }

        public async Task<bool> DeleteSearchAsync(SearchHistory search)
        {
            _applicationDbContext.Remove(search);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }
    }
}

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
namespace SearchEngine.Models
{
    
    public class SearchHistory
    {
        [Key]
        public int SearchId { get; set; }
        public string UserId { get; set; }
        public string SearchTerm { get; set; }
        public string Site { get; set; }

        public virtual List<SearchHistory> Searches { get; set; }
    }

}

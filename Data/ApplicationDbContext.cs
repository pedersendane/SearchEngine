using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SearchEngine.Models;
using System.Collections.Generic;


namespace SearchEngine.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }

       public DbSet<SearchHistory> Searches { get; set; }
    }
}

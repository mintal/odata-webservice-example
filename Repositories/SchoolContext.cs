using Microsoft.EntityFrameworkCore;
using ODataWebService.Models;

namespace ODataWebService.Repositories
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }
        
        public DbSet<Student> Students { get; set; }
    }
}
using E_project_book_mangement_system.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace E_project_book_mangement_system.context
{
    public class SqlContext:DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> option): base(option) {
        
        
        }
        public DbSet<Register> registers { get; set; }

    }
}

using BookStore.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookStore.DataAccess;

public class BookStoreDatabaseContext : DbContext
{
    
    public BookStoreDatabaseContext(DbContextOptions<BookStoreDatabaseContext> options) : base(options)
    {
        
    }
    
    public DbSet<BookEntity> Books { get; set; }
    
        
}
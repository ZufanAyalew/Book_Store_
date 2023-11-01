using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Book_Store_.Models;

namespace Book_Store_.Data
{
    public class Book_Store_Context : DbContext
    {
        public Book_Store_Context (DbContextOptions<Book_Store_Context> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = default!;
    }
}

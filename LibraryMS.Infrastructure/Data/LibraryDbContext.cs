using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryMS.Infrastructure.Data
{
    public class LibraryDbContext:DbContext
    {
        
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        {

        }
    }
}

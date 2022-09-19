using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeMVCApp.Models;

namespace CodeMVCApp.Data
{
    public class CodeMVCAppContext : DbContext
    {
        public CodeMVCAppContext (DbContextOptions<CodeMVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<CodeMVCApp.Models.Category> Category { get; set; } = default!;
    }
}

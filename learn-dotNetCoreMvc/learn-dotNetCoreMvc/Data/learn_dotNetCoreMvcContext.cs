using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using learn_dotNetCoreMvc.Models;

namespace learn_dotNetCoreMvc.Data
{
    public class learn_dotNetCoreMvcContext : DbContext
    {
        public learn_dotNetCoreMvcContext (DbContextOptions<learn_dotNetCoreMvcContext> options)
            : base(options)
        {
        }

        public DbSet<learn_dotNetCoreMvc.Models.Movie> Movie { get; set; } = default!;
    }
}

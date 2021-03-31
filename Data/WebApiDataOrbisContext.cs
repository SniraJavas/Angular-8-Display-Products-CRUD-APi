using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiDataOrbis.Models;

namespace WebApiDataOrbis.Data
{
    public class WebApiDataOrbisContext : DbContext
    {
        public WebApiDataOrbisContext (DbContextOptions<WebApiDataOrbisContext> options)
            : base(options)
        {
        }

        public DbSet<WebApiDataOrbis.Models.Product> Product { get; set; }
    }
}

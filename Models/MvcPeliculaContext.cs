using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MvcPeliculas.Models
{
    public class MvcPeliculaContext : DbContext
    {
        public MvcPeliculaContext (DbContextOptions<MvcPeliculaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcPeliculas.Models.Pelicula> Pelicula { get; set; }
    }
}
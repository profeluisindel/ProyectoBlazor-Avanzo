using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace APP_avanzo.Server.data
{
    public class AplicationDBContext(DbContextOptions<AplicationDBContext> options) : DbContext(options)
    {
        public DbSet<Calcular2> Calculos => Set<Calcular2>();
    }
}
using API_GESTORES.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_GESTORES.contextDB
{
    public class contextDB : DbContext
    {
        public contextDB(DbContextOptions<contextDB> options): base(options)
        {

        }

        public DbSet<Gestores>
    }
}

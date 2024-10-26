using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleFacil.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleFacil.Api.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Usuario> Usuario {get; set;}
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;
using Dominio.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class skeletonEsApiContext : DbContext
    {
        public skeletonEsApiContext(DbContextOptions<skeletonEsApiContext> options) : base(options)
        {
        }
    }
}
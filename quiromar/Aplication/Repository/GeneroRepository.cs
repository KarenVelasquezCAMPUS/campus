using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository
{
    public class GeneroRepository : GenericRepository<Genero> /* //No permite tener la interfase IGeneroRepository */
    {
        public GeneroRepository(ApiPushUpQuiomarContext context) : base(context)
        {
        }
    }
}
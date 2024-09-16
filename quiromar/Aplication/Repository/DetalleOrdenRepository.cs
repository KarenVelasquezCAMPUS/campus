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
    public class DetalleOrdenRepository : GenericRepository<DetalleOrden> /* //No permite tener la interfase  IDetalleOrdenRepository */
    {
        public DetalleOrdenRepository(ApiPushUpQuiomarContext context) : base(context)
        {
        }
    }
}
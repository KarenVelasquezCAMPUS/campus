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
    public class FormaPagoRepository : GenericRepository<FormaPago> /* //No permite tener la interfase IFormaPagoRepository */
    {
        public FormaPagoRepository(ApiPushUpQuiomarContext context) : base(context)
        {
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository
{
    public class CountryRepository : GenericRepositoryInt<Country>, ICountryRepository
    {
        public CountryRepository(IncidenciasContext context): base(context)
        {
        }
    }
}
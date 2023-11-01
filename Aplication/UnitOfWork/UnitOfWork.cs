using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aplication.Repository;
using Domain.Interfaces;
using Persistence;

namespace Aplication.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly IncidenciasContext _context;
        private CountryRepository countries;
        public ICountryRepository CountryRepository => throw new NotImplementedException();

        public IGenderRepository GenderRepository => throw new NotImplementedException();

        public IPersonRepository PersonRepository => throw new NotImplementedException();
        public ICountryRepository Countries
        {
            get
            {
                if (countries == null)
                {
                    countries = new CountryRepository(_context);
                }
                return countries;
            }
        }



        public void Dispose()
        {
            _context.Dispose();
        }
        public int Save()
        {
            return _context.SaveChanges();
        }
    }
}
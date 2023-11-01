using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Aplication.Repository
{
    public class GenerRepository : IGenderRepository
    {
        public void Add(Gender entity)
        {
            throw new NotImplementedException();
        }

        public void AddRange(IEnumerable<Gender> entities)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Gender>> Find(Expression<Func<Gender, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Gender>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Gender> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Gender entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<Gender> entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Gender entity)
        {
            throw new NotImplementedException();
        }
    }
}
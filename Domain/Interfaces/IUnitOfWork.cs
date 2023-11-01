using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        ICountryRepository CountryRepository { get; }
        IGenderRepository GenderRepository { get; }
        IPersonRepository PersonRepository { get; }

    }
}
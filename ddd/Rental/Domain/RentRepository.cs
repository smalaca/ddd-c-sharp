using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Domain
{
    public interface RentRepository
    {
        void Add(Rent rent);
    }
}

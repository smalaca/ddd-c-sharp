using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Domain
{
    public interface OfferRepository
    {
        Offer FindBy(long offerId);
    }
}

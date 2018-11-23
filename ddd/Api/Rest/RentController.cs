using DDD.Api.Rest.Domain;
using DDD.Rental.Domain;
using DDD.Rental.Domain.Dto;
using DDD.Semantic;
using DDD.Web.Http;
using System;

namespace DDD.Api.Rest
{
    class RentController
    {
        private RentRentalSpaceService service;
        private SemanticsFacade semanticsFacade;

        public RentController(RentRentalSpaceService service, SemanticsFacade semanticsFacade)
        {
            this.service = service;
            this.semanticsFacade = semanticsFacade;
        }

        public HttpResponse Rent(long offerId)
        {
            RentRequestDto rentalRequestDto = new RentRequestDto(offerId);

            Semantics semantics = semanticsFacade.Verify(rentalRequestDto);

            if (semantics.IsCorrect())
            {
                service.Process(rentalRequestDto);
                return HttpResponse.Ok(RestCallResponse.Ok());
            }
            else
            {
                return HttpResponse.Ok(RestCallResponse.Failure(semantics.Failures()));
            }

        }
    }
}

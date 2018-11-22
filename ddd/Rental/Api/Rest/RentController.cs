using DDD.Rental.Api.Rest.Domain;
using DDD.Rental.Domain;
using DDD.Rental.Domain.Dto;
using DDD.Rental.Semantic;
using DDD.Rental.Web.Http;
using System;

namespace DDD.Rental.Api.Rest
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

        public HttpResponse Rent(long tenantId, long rentalSpaceId, DateTime fromDate, DateTime toDate)
        {
            RentRequestDto rentalRequestDto = new RentRequestDto(tenantId, rentalSpaceId, fromDate, toDate);

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

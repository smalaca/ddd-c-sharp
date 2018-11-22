using System;
using System.Collections.Generic;
using System.Text;

namespace DDD.Rental.Api.Rest.Domain
{
    public class RestCallResponse
    {
        internal static string Ok()
        {
            return "{status:success}";
        }

        internal static string Failure(string message)
        {
            return "{status:failure, message: " + message + "}";
        }
    }
}

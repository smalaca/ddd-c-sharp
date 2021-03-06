﻿namespace DDD.Web.Http
{
    
    class HttpResponse
    {
        private HttpStatus status;
        private string message;

        private HttpResponse(HttpStatus status, string message)
        {
            this.status = status;
            this.message = message;
        }

        internal static HttpResponse Ok(string message)
        {
            return new HttpResponse(HttpStatus.OK, message);
        }

        private enum HttpStatus
        {
            OK
        }
    }
}

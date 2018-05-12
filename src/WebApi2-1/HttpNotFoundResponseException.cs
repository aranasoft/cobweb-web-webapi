﻿using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cobweb.Web.Http.Formatting;

namespace Cobweb.Web.Http {
    public class HttpNotFoundResponseException : HttpResponseException {
        public HttpNotFoundResponseException(string reason, string errorMessage)
            : base(
                new HttpResponseMessage(HttpStatusCode.NotFound) {
                    ReasonPhrase = reason,
                    Content = new JsonErrorObjectContent(errorMessage)
                }) {}
    }
}

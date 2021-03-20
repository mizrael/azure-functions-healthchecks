using System.Net;
using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;

namespace MyHealthyFuncApp
{
    public class MyFunction
    {
        [Function(nameof(SayHello))]
        public static HttpResponseData SayHello([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "hello")] HttpRequestData req,
    FunctionContext executionContext)
        {
            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Headers.Add("Date", "Mon, 18 Jul 2016 16:06:00 GMT");
            response.Headers.Add("Content-Type", "text/plain; charset=utf-8");

            response.WriteString("Hello!");

            return response;
        }
    }
}
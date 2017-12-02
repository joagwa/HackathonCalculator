using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class CalculatorController : ApiController
    {
        [HttpGet]
        [Route(@"svc/add/{number1}/{number2}")]
        public async Task<IHttpActionResult> Add([FromUri]double number1, [FromUri]double number2)
        {
            var result = number1 + number2;
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.Accepted, result));
        }

        [HttpGet]
        [Route(@"svc/subtract/{number1}/{number2}")]
        public async Task<IHttpActionResult> Subtract([FromUri]double number1, [FromUri]double number2)
        {
            var result = number1 - number2;
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.Accepted, result));
        }

        [HttpGet]
        [Route(@"svc/multiply/{number1}/{number2}")]
        public async Task<IHttpActionResult> Multiply([FromUri]double number1, [FromUri]double number2)
        {
            double result = number1 * number2;
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.Accepted, result));
        }

        [HttpGet]
        [Route(@"svc/divide/{number1}/{number2}")]
        public async Task<IHttpActionResult> Divide([FromUri]double number1, [FromUri]double number2)
        {
            double result = number1 / number2;
            return ResponseMessage(Request.CreateResponse(HttpStatusCode.Accepted, result));
        }
    }
}

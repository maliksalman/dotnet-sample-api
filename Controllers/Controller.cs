using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers
{
    [ApiController]
    public class Controller : ControllerBase
    {

        [HttpGet]
        [Route("/")]
        public Payload GetString() {
            return new Payload(DateTime.UtcNow, Dns.GetHostName(), "Hello, World");
        }

    }
}
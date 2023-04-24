using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapi.Services;

namespace webapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : ControllerBase
    {
        IHelloWorldService helloworldService;
        
        public HelloWorldController( IHelloWorldService helloworldService )
        {
            this.helloworldService = helloworldService;
        }
        
        public IActionResult Get()
        {
            return Ok( helloworldService.getHelloWord() );
        }
    }
}
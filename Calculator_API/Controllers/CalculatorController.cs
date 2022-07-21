using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Calculator_Logic;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Calculator_API.Controllers
{
    [Route("api/[controller]")]
    public class CalculatorController : Controller
    {
        Calculator calc;
        

        public CalculatorController()
        {
            calc = new Calculator();
        }

        [HttpGet]
        [Route("add/{left}/{right}")]
        public double add(double left, double right)
        {

            return calc.Add(left, right);

        }

        [HttpGet]
        [Route("subtract/{left}/{right}")]
        public double subtract(double left, double right)
        {

            return calc.Subtract(left, right);

        }

        [HttpGet]
        [Route("multiply/{left}/{right}")]
        public double multiply(double left, double right)
        {

            return calc.Multiply(left, right);

        }

        [HttpGet]
        [Route("divide/{left}/{right}")]
        public ActionResult divide(double left, double right)
        {
            try
            {
                return Ok(calc.Divide(left, right));
            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: (int)HttpStatusCode.BadRequest);
            }
            

        }

    }
}

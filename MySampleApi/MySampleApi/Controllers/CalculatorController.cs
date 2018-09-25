using myDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySampleApi.Business;
using myDataLayer.EF;

namespace MySampleApi.Controllers
{
    /// <summary>
    /// Test Single Binding is Working 
    /// </summary>
    public class CalculatorController : ApiController
    {
      
       private readonly ICaclulator _caclulator;
       

     public  CalculatorController(ICaclulator calculator)
       {
            _caclulator = calculator;
           
        }


        /// Test Ninject works 
        [HttpGet]    
        public IHttpActionResult Get(int num1, int num2)
        {
            try
            {
                var conversations = _caclulator.Add(num1, num2);
                return Ok(conversations);

            }
            catch
            {
                return InternalServerError();
            }
            
        }

      
       
       
    }
}

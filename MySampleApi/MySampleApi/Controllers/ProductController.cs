using EntityModellibrary;
using myDataLayer;
using myDataLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MySampleApi.Controllers
{

    /// <summary>
    /// Call Products and test ninject Binding is working 
    /// </summary>
    public class ProductController : ApiController
    {
        private readonly GlobalAMEntities _db;
        private readonly IProdRepository _prod;

     public   ProductController(GlobalAMEntities Db, IProdRepository prod)
       {
           
            _db = Db;
            _prod = prod;
        }
        
        
        
        
        // GET api/<controller>


        [HttpGet]
        public IHttpActionResult Products()
        {
            try
            {
                var _Products = _prod.Getuam2_market1().Take(10);
                
                return Ok(_Products);

            }
            catch
            {
                return InternalServerError();
            }

            
        }

        // GET api/<controller>/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                var _Products = _prod.Getuam2_market1().Where(t => t.RecordID == id).Select(
                    t => new ProductEntity()
                    {
                        RecordID = t.RecordID,
                        CompanyType = t.CompanyType,
                        MarketID = t.MarketID,
                        IsActive = t.IsActive

                    }



                    ).FirstOrDefault();

                return Ok(_Products);

            }
            catch
            {
                return InternalServerError();
            }
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
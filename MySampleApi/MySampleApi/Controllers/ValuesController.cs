using MySampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace MySampleApi.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        public IHttpActionResult Get(int id, int id1)
        {
            var conversations = id+id1;
            return Ok(conversations);
        }

        //public IHttpActionResult Get(int id,int id1)
        //{
        //    IHttpActionResult response;//= new HttpResponseMessage(HttpStatusCode.OK);
        //                               //response.Content = new ByteArrayContent(byte[](id + id1));
        //                               //return response;

        //    if (id == 0 && id1==0)
        //    {
        //        return NotFound();
        //    }
        //    string hashedOrderEtag = $"\"{hashedOrder}\"";
        //    // Create the Cache-Control and ETag headers for the response

        //    var cacheControlHeader = new CacheControlHeaderValue();
        //    cacheControlHeader.Public = true;
        //    cacheControlHeader.MaxAge = new TimeSpan(0, 10, 0);
        //    var eTag = new EntityTagHeaderValue(hashedOrderEtag);

        //    // Retrieve the If-None-Match header from the request (if it exists)
        //    var nonMatchEtags = Request.Headers.IfNoneMatch;

        //    // If there is an ETag in the If-None-Match header and
        //    // this ETag matches that of the order just retrieved,
        //    // then create a Not Modified response message
        //    if (nonMatchEtags.Count > 0 &&
        //        String.CompareOrdinal(nonMatchEtags.First().Tag, hashedOrderEtag) == 0)
        //    {
        //        response = new EmptyResultWithCaching()
        //        {
        //            StatusCode = HttpStatusCode.NotModified,
        //            CacheControlHeader = cacheControlHeader,
        //            ETag = eTag
        //        };
        //    }
        //    // Otherwise create a response message that contains the order details
        //    else
        //    {
        //        response = new OkResultWithCaching<Order>(order, this)
        //        {
        //            CacheControlHeader = cacheControlHeader,
        //            ETag = eTag
        //        };
        //    }
        //    return response;
        //}
        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}

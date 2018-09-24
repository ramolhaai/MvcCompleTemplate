using myDataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using myDataLayer.EF;

namespace MySampleApi.Controllers
{
    public class ValuedbController : ApiController
    {
       private readonly IProdRepository _db;
        ValuedbController(IProdRepository db) {
            _db = db;
        }

        public List<Product> Get()
        {

            return _db.GetProducts().ToList();
        }
    }
}

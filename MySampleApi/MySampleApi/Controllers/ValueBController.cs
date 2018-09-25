using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MySampleApi.Business;
using myDataLayer.EF;
using myDataLayer;

namespace MySampleApi.Controllers
{
    public class ValueBController : ApiController
    {
        private readonly ICaclulator _caclulator;
        private readonly GlobalAMEntities _db;
        private readonly IProductRepository _prod;
        public ValueBController(ICaclulator calculator, GlobalAMEntities Db)
        {
            _caclulator = calculator;
            _db = Db;
          
        }

       
        public int Get(int num1, int num2)
        {
            return _caclulator.Add(num1, num2);
        }

        public int Get1()
        {
            var icnt = _db.uam2_market1.Count();
            return icnt;
        }

       

    }
}

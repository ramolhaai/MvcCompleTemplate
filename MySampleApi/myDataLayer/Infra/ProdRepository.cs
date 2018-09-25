using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using myDataLayer.EF;

namespace myDataLayer
{
   public class ProdRepository :  IProdRepository
    {
       private readonly GlobalAMEntities _db;

     public  ProdRepository(GlobalAMEntities db)
        {
            _db = db;
        }
        public uam2_market1 FindBy(int id)
        {
            return _db.uam2_market1.Where(t => t.RecordID == id).FirstOrDefault();
        }

        public IQueryable<uam2_market1> Getuam2_market1ByFilter(Expression<Func<uam2_market1, bool>> predicate, int excludedRows, int take)
        {
            return _db.uam2_market1.Where(predicate).Skip(excludedRows).Take(take);
        }

        public IEnumerable<uam2_market1> Getuam2_market1()
        {
            return _db.uam2_market1.ToList();
        }


       
    }
}

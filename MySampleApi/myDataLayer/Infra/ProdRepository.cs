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
        private readonly NorthwindEntities _db;

       public ProdRepository(NorthwindEntities db)
        {
            _db = db;
        }
        public Product FindBy(int id)
        {
            return _db.Products.Where(t => t.ProductID == id).FirstOrDefault();
        }

        public IQueryable<Product> GetProductByFilter(Expression<Func<Product, bool>> predicate, int excludedRows, int take)
        {
            return _db.Products.Where(predicate).Skip(excludedRows).Take(take);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _db.Products.ToList();
        }
    }
}

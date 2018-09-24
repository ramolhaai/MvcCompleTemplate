using myDataLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace myDataLayer
{
   public interface IProductRepository: IRepositoryQuery<Product,int>
    {
        
        IQueryable<Product> GetProductByFilter(Expression<Func<Product, bool>> predicate, int excludedRows, int take);

        IEnumerable<Product> GetProducts();
    }

    public interface IProdRepository
    {

        IQueryable<Product> GetProductByFilter(Expression<Func<Product, bool>> predicate, int excludedRows, int take);

        IEnumerable<Product> GetProducts();
    }
}
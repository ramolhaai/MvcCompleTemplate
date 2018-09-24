using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDataLayer
{
    interface IRepository<in TEntity, out TKey> where TEntity : IQuery where TKey :IResult
    {
      IEnumerable<TKey> GetProducts();
    }

    interface IQuery { }
    interface IResult { }
}

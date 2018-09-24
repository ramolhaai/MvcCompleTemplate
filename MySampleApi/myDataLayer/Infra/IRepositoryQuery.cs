using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myDataLayer
{
    

    public interface IRepositoryQuery<TEntity, in TKey> where TEntity : class
    {
        TEntity FindBy(TKey id);
    }
}

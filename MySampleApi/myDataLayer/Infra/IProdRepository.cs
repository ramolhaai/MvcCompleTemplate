using myDataLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace myDataLayer
{
    public interface IProdRepository : IRepositoryQuery<uam2_market1, int>
    {
        
        IQueryable<uam2_market1> Getuam2_market1ByFilter(Expression<Func<uam2_market1, bool>> predicate, int excludedRows, int take);

        IEnumerable<uam2_market1> Getuam2_market1();
    }

    
}
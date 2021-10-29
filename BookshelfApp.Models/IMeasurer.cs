using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshelfApp.Models
{
    public interface IMeasurer<TEntity>
    {
        //double Calculate(object entity);
        double Calculate(TEntity entity);
    }

    //public interface IMeasurer<TEntity> : IMeasurer
    //{
    //}
}

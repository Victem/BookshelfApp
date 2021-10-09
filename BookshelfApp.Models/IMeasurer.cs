using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshelfApp.Models
{
    public interface IMeasurer
    {
        double Calculate(object entity);
    }

    public interface IMeasurer<TEntity> : IMeasurer
    {
        double Calculate(TEntity entity);
    }
}

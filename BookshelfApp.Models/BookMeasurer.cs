using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace BookshelfApp.Models
{
    public class BookMeasurer : IMeasurer<PrintingProduction>
    {
        public double Calculate(PrintingProduction entity)
        {
            var type = entity.GetType();

            var pageSizeAttribute = type.GetCustomAttribute<PageSizeAttribute>();

            if (pageSizeAttribute != null)
            {
                var pageSize = pageSizeAttribute.PageSize;
                return entity.Pages * pageSize;
            }
            return entity.Pages * 0.5;
        }
    }
}

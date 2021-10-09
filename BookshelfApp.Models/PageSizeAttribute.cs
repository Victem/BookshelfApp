using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshelfApp.Models
{
    [AttributeUsage(AttributeTargets.Class)]
    public class PageSizeAttribute : Attribute
    {
        public double PageSize { get; set; }
        public PageSizeAttribute(double pageSize)
        {
            PageSize = pageSize;
        }
    }
}

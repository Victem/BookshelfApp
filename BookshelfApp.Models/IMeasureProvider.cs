using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshelfApp.Models
{
    interface IMeasureProvider<T>
    {
        IMeasurer<T> Measurer { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshelfApp.Models
{
    interface IMeasureProvider
    {
        IMeasurer Measurer { get; set; }
    }
}

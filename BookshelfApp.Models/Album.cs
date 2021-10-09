using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshelfApp.Models
{
    [PageSize(1.5)]
    public class Album : PrintingProduction, IMeasurable, IMeasureProvider
    {
        public IMeasurer Measurer { get; set; } = new BookMeasurer();

        public double GetWidth()
        {
            return Measurer.Calculate(this);
        }
    }
}

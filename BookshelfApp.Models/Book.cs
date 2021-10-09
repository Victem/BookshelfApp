using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshelfApp.Models
{
    public class Book : PrintingProduction, IMeasurable, IMeasureProvider
    {
        public string Name { get; set; }

        public string Author { get; set; }

        public IMeasurer Measurer { get; set; } = new BookMeasurer();

        public double GetWidth()
        {
            return Measurer.Calculate(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshelfApp.Models
{
    public class Bookshelf
    {
        private List<IMeasurable> items = new List<IMeasurable>();
        public int Width { get; private set; }
        public Bookshelf(int width)
        {
            Width = width;
        }
        public void AddItem(IMeasurable item)
        {
            if (CanAdd(item))
            {
                items.Add(item);
            }
        }

        public IMeasurable ExtractBook(IMeasurable item)
        {
            items.Remove(item);
            return item;
        }

        public double AvailableSpace { get => Width - items.Sum(b => b.GetWidth()); }

        public bool CanAdd(IMeasurable item)
        {
            return AvailableSpace - item.GetWidth() >= 0;
        }
    }
}

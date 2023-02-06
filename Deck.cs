using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleTester
{
    public class Deck
    {
        public int Size { get; }

        public List<int> Order { get; private set; }

        public Deck(int size)
        {
            Size = size;

            Order = new List<int>();
            for (int i = 0; i < size; i++)
            {
                Order.Add(i);
            }
        }
    }
}

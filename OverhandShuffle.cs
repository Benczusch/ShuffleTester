using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleTester
{
    internal class OverhandShuffle : IShuffler
    {
        private int _chunkSize;

        public OverhandShuffle(int chunkSize)
        {
            _chunkSize = chunkSize;
        }


        public void Shuffle(Deck deck)
        {
            throw new NotImplementedException();
        }
    }
}

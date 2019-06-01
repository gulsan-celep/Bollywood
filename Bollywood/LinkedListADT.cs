using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bollywood
{
   public abstract class LinkedListADT
    {
        public Node Head;
        public int Size = 0;
        public abstract void InsertPos(int position, int value);
        public abstract bool DeletePos(int position);
        public abstract Node GetElement(int position);

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace gyak10
{
    internal class FIFO<T>
    {
        private LinkedList<T> elemek = new LinkedList<T> ();

        public void Hozzad(T ertek)
        {
            elemek.AddLast (ertek);
        }

        public T Torol()
        {
            if (elemek.Count == 0)
            {
                return default;
            }
            T elso = elemek.First.Value;
            elemek.RemoveFirst();
            return elso;
        }

        public T Leker()
        {
            if (elemek.Count == 0)
            {
                return default;
            }
            return elemek.First.Value;
        }
    }
}

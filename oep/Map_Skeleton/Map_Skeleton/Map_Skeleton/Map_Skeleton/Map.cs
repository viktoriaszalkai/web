using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Map_Skeleton
{
    public class Map
    {
        public class NonExistingKeyException : Exception { }
        public class ExistingKeyException : Exception { }

        private List<Element> seq;

        public Map()
        {
            seq = new List<Element>();

        }
        public void SetEmpty()
        {
            seq.Clear();
        }
        public int Count()
        {
            return seq.Count;
        }

        private (bool, int) LogSearch(int key)
        {
            bool l = false;
            int ah = 0;
            int fh = seq.Count - 1;

            int ind = 0;

            while (!l && ah <= fh)
            {
                ind = (ah + fh) / 2;
                if (seq[ind].key == key)
                {
                    l = true;
                }
                else if (seq[ind].key > key)
                {
                    fh = ind - 1;
                }
                else if (seq[ind].key < key)
                {
                    ah = ind + 1;
                }
            }
            if (!l)
            {
                ind = ah;
            }
            return (l, ind);
        }

        public void Insert(Element e)
        {
            bool l;
            int ind;

            (l, ind) = LogSearch(e.key);
            if (l)
            {
                throw new ExistingKeyException();
            }
            else
            {
                seq.Insert(ind, e);
            }
        }

        public void Remove(int key)
        {
            bool l;
            int ind;

            (l, ind) = LogSearch(key);

            if (!l)
            {
                throw new NonExistingKeyException();
            }
            seq.RemoveAt(ind);
        }

        public bool In(int key)
        {
            bool l;
            int ind;

            (l, ind) = LogSearch(key);

            return l;
        }

        public string Select(int key)
        {
            bool l;
            int ind;

            (l, ind) = LogSearch(key);

            if (!l)
            {
                throw new NonExistingKeyException();
            }
            return seq[ind].data;
        }

        public override string ToString()
        {
            string output = "[";
            foreach (Element e in seq)
            {
                output += e.ToString();
            }
            output += "]";
            return output;
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.CSharp.Sort
{
    public class QuickSort<T> where T : IComparable
    {
        private readonly IList<T> _list;

        public IList<T> List => _list;

        public QuickSort(IList<T> array)
        {
            _list = array;
        }

        public void Sort()
        {
            Sort(0, _list.Count() - 1);
        }

        private void Sort(int lo, int hi)
        {
            if (lo >= hi)
            {
                return;
            }

            var j = Partition(lo, hi);
            Sort(lo, j - 1);
            Sort(j + 1, hi);
        }

        private int Partition(int lo, int hi)
        {
            int i = lo, j = hi + 1;
            T t = _list[lo];

            while (true)
            {
                while (_list[++i].CompareTo(t) < 0)
                {
                    if (i == hi) break;
                }
                while (_list[--j].CompareTo(t) > 0)
                {
                    if (j == lo) break;
                }
                if (i >= j) break;
                Exchange(i, j);
            }
            Exchange(lo, j);
            return j;
        }

        private void Exchange(int i, int j)
        {
            T tmp = _list[i];
            _list[i] = _list[j];
            _list[j] = tmp;
        }
    }
}

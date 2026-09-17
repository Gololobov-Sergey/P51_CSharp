using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P51_CSharp
{
    internal class Iter
    {
        List<int> list = new List<int>() { 1, 2, 6, 8, 0, 9, 7, 5, 433, 568 };

        public IEnumerable<int> GetEvenEnumerator()
        {
            foreach (var item in list)
            {
                if (item % 2 == 0)
                    yield return item;
            }
        }
    }


    internal class Alphabet : IEnumerable<char>
    {
        string alphabet = "qwertyuiopasdfghjklzxcvbnm";

        //public IEnumerable<char> GetEnumerator()
        //{
        //    foreach (var item in alphabet)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator<char> IEnumerable<char>.GetEnumerator()
        {
            return alphabet.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return alphabet.GetEnumerator();
        }
    }
}

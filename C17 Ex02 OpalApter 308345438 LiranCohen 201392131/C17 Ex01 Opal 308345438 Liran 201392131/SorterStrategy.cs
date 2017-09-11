using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C17_Ex02_Opal_308345438_Liran_201392131
{
    public class SorterStrategy<T>
    {
        public Func<T, T, bool> ComparerMethod { get; set; }

        public SorterStrategy(Func<T, T, bool> i_ComparerMethod)
        {
            ComparerMethod = i_ComparerMethod;
        }

        public List<T> Sort(List<T> i_Array)
        {
            List<T> o_Array = new List<T>();
            o_Array=i_Array;

            for (int i = 0; i < o_Array.Count; i++)
            {
                for (int j = 0; j < o_Array.Count - 1; j++)
                {
                    if (ComparerMethod.Invoke(o_Array[j], o_Array[j+1]))
                    {
                        T temp=o_Array[j];
                        o_Array[j] = o_Array[j + 1];
                        o_Array[j + 1] = temp;
                    }
                }
            }
            return o_Array;
        }
    }
}

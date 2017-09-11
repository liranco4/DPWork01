using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace C17_Ex02_Opal_308345438_Liran_201392131
{
    public class Sorter<T>
    {
        public Func<T, T, bool> ComparerMethod { get; set; }

        public Sorter(Func<T, T, bool> i_ComparerMethod)
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
                        //Swap(ref i_Array[j], ref i_Array[j+1]);
                        T temp=o_Array[j];
                        o_Array[j] = o_Array[j + 1];
                        o_Array[j + 1] = temp;
                    }
                }
            }
            return o_Array;

            /*for (int g = i_Array.Length / 2; g > 0; g /= 2)
            {
                for (int i = g; i < i_Array.Length; i++)
                {
                    for (int j = i - g; j >= 0; j -= g)
                    {
                        if (ComparerMethod.Invoke(i_Array[j], i_Array[j + g]))
                        {
                            Swap(ref i_Array[j], ref i_Array[j + g]);
                        }
                    }
                }
            }*/
        }

        private void Swap(ref T io_Num1, ref T io_Num2)
        {
            T temp = io_Num1;
            io_Num1 = io_Num2;
            io_Num2 = temp;
        }
    }
}

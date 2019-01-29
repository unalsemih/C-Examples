using System;
using System.Collections.Generic;
using System.Text;

namespace MyArrayList
{
    class MyArrayList
    {

        public Object[] nesneler = new Object[10];
        int capacity = 10;
        int count = 0;

        public int Capacity { get => capacity; }
        public int Count { get => count; }

        public void Add(Object nesne)
        {
            if (Count == Capacity)
            {
                capacity *= 2;
                Array.Resize(ref nesneler, capacity);
            }
            nesneler[Count] = nesne;
            count++;
        }

        public void Remove(Object nesne)
        {
            for (int i = 0; i < count; i++)
                if (nesneler[i] == nesne)
                {

                    for (int j = i; j < nesneler.Length - 1; j++)
                        nesneler[j] = nesneler[j + 1];
                    count--;
                    break;
                }

        }

        public int IndexOf(Object nesne)
        {
            int index = -1;
            for (int i = 0; i < nesneler.Length; i++)
                if (nesne == nesneler[i])
                    index = i;
            return index;
        }

        public void Remove1(Object nesne)
        {
            RemoveAt(IndexOf(nesne));
        }

        public void RemoveAt(int index)
        {
            if (index >= 0 && index <= count)
            {
                for (int i = index; i < count; i++)
                    nesneler[i] = nesneler[i + 1];
                count--;
            }
        }


        public Object this[int index]
        {
            get
            {
                return nesneler[index];
            }
            set
            {
                nesneler[index] = value;
            }
        }

        public static void Reverse(MyArrayList diziListesi)
        {

            object gecici;

            for (int i = 0; i < diziListesi.Count / 2; i++)
            {
                gecici = diziListesi[i];
                diziListesi[i] = diziListesi[diziListesi.Count - i - 1];
                diziListesi[diziListesi.Count - i - 1] = gecici;
            }


        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task3
{
    class DynamicArray<T>
    {
        private int _defaultCapacity = 8;
        private T [] _dynamicArray;
        public int Capacity { get; set; }

        public int Lenght
        {
            get
            {
                int _count = 0;
                foreach (object o in _dynamicArray)
                {
                    _count++;
                }
                return _count;
            }
        }

        /// <summary>
        /// Consctructor without parameters (use default capacity).
        /// </summary>
        public DynamicArray() {
            _dynamicArray = new T [_defaultCapacity];
        }

        /// <summary>
        /// Constructor with one parameter (capacity).
        /// </summary>
        /// <param name="n">Capacity of array.</param>
        public DynamicArray(int n)
        {
            if (n > 0)
            {
                _dynamicArray = new T [n];
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Constructor that create array with input collections items.
        /// </summary>
        /// <param name="collection">Input collection (IEnumerable<T>).</param>
        public DynamicArray(IEnumerable<T> collection)
        {
            // Calculating count of elements.
            int _count = collection.Count();

            _dynamicArray = new T[_count];

            // Coping values from collection to array.
            _count = 0;

            IEnumerator<T> enumerator = collection.GetEnumerator();
            for (int i = 0; i < _count; i++)
            {
                enumerator.MoveNext();
                this._dynamicArray[i] = enumerator.Current;
            }
        }


        /// <summary>
        /// Add element to last index in array.
        /// </summary>
        /// <param name="element">Element.</param>
        public void Add(T element)
        {
            if ((Lenght + 1) >= Capacity)
            {
                Resize();
                _dynamicArray[this.Lenght + 1] = element;
            }
            else
            {
                _dynamicArray[this.Lenght + 1] = element;
            }
        }


        public void AddRange(IEnumerable<T> collection)
        {
            // Calculating count of elements.
            int _count = collection.Count();
            if (Lenght + _count >= Capacity)
            {
                Resize(Lenght + _count + 1);
            }
            
            IEnumerator<T> enumerator = collection.GetEnumerator();
            int i = Lenght;
            while (enumerator.MoveNext())
            {
                _dynamicArray[i] = enumerator.Current;
                i++;
            }
            




        }


        /// <summary>
        /// Increases the capasity of array.
        /// </summary>
        public void Resize()
        {
            T[] temp = new T[Capacity * 2];
            _dynamicArray.CopyTo(temp, 0);
            _dynamicArray = temp;
        }

        /// <summary>
        /// Changes the capasity of array to n items.
        /// </summary>
        /// <param name="n">New capacity of array.</param>
        public void Resize(int n)
        {
            // Check is n less then current capacity.
            if (n < Capacity)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                T[] temp = new T[n];
                _dynamicArray.CopyTo(temp, 0);
                _dynamicArray = temp;
            }
        }

        //TODO: Complete other tasks. 

    }
}

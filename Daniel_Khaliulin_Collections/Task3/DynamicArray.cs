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
        private int _capacity;
        public int Capacity
        {
            get {
                return _capacity;
            }
            private set {
                _capacity = value;
            }
        }

        /// <summary>
        /// Consctructor without parameters (use default capacity).
        /// </summary>
        public DynamicArray() {
            _dynamicArray = new T [_defaultCapacity];
            Capacity = _defaultCapacity;
        }

        /// <summary>
        /// Constructor with one parameter (capacity).
        /// </summary>
        /// <param name="n"></param>
        public DynamicArray(int n)
        {
            if (n > 0)
            {
                _dynamicArray = new T [n];
                Capacity = n;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Copy elements from input collection to array.
        /// </summary>
        /// <param name="collection"></param>
        public DynamicArray(IEnumerable<T> collection)
        {
            // Calculating count of elements.
            int _count = 0;
            foreach (object o in collection)
            {
                _count++;
            }

            _dynamicArray = new T[_count];

            // Coping values from collection to array.
            _count = 0;
            foreach (T value in collection)
            {
                _dynamicArray[_count] = value;
            }
        }

        public void Add(T element)
        {
            if (Capacity >= Lenght)
            {

            }
            else
            {
                Capacity = Capacity * 2;
                // TODO: complete other exercises of this task 
            }
        }


        public int Lenght 
        {
            get
            {
                return _dynamicArray.Length;
            }
        }

    }
}

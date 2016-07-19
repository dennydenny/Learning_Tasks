using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Task3
{
    class DynamicArray<T> : IEnumerable<T>, IEnumerator<T>, IEnumerable, IEnumerator
    {
        private int _defaultCapacity = 8;
        private T [] _dynamicArray;
        private int _index = 0;
        public int Capacity { get; set; }

        public int Length
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
            if ((Length + 1) >= Capacity)
            {
                Resize();
                _dynamicArray[this.Length + 1] = element;
            }
            else
            {
                _dynamicArray[this.Length + 1] = element;
            }
        }

        /// <summary>
        /// Adds IEnumerable<T> collection to end of array.
        /// </summary>
        /// <param name="collection">Collection, that will be added to end of array.</param>
        public void AddRange(IEnumerable<T> collection)
        {
            // Calculating count of elements.
            int _count = collection.Count();
            if (Length + _count >= Capacity)
            {
                Resize(Length + _count + 1);
            }
            
            IEnumerator<T> enumerator = collection.GetEnumerator();
            int i = Length;
            while (enumerator.MoveNext())
            {
                i++;
                _dynamicArray[i] = enumerator.Current;  
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
        /// Changes the capacity of array to n items.
        /// </summary>
        /// <param name="n">New capacity of array.</param>
        public void Resize(int n)
        {
            // Check is n less then current capacity.
            if (n <= Capacity)
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

        /// <summary>
        /// Removes item from array.
        /// </summary>
        /// <param name="item">Item, that need to be removed.</param>
        /// <returns>true if the item was succesfully removed, false when not.</returns>
        public bool Remove(T item)
        {
            for (int i = 0; i < Length; i++)
            {
                if (_dynamicArray[i].Equals(item))
                {
                    T[] temp = new T[Capacity];
                    Array.Copy(_dynamicArray, 0, temp, 0, i);
                    Array.Copy(_dynamicArray, i+1, temp, i, _dynamicArray.Length - i - 1);
                    _dynamicArray = temp;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Inserts item to choosen position in array.
        /// </summary>
        /// <param name="index">Index of position in array, where need to insert item.</param>
        /// <param name="item">Item.</param>
        /// <returns></returns>
        public bool Insert(int index, T item)
        {
            if (index >= Length || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                if (Length + 1 >= Capacity)
                {
                    Resize();
                }
                Array.Copy(_dynamicArray, index, _dynamicArray, index + 1, Length);
                _dynamicArray[index] = item;
                return true;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)this;
        }

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (_index == Length)
            {
                return false;
            }
            _index++;
            return true;
        }

        public T Current
        {
            get
            {
                if (_index >= 0 && _index < Length)
                {
                    return _dynamicArray[_index];
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        public void Reset()
        {
            _index = -1;
        }

        /// <summary>
        /// Returns item with choosen index.
        /// </summary>
        /// <param name="index">Item index in array.</param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                if (index >= 0 || index < Length)
                {
                    return _dynamicArray[index];
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 || index < Length)
                {
                    _dynamicArray[index] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

    }
}

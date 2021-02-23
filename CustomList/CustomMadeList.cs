using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class CustomMadeList<T>
    {
        private int count;
        private int capacity;
        private T[] items;

        public CustomMadeList()
        {
            count = 0;
            capacity = 4;
            items = new T[capacity];
        }

        public int Capacity
        {
            get
            {
                return capacity;
            }
        }

        public void Add(T newItem)
        {

        }

        public int CountItems()
        {

        }
    }
}

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

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(T newItem)
        {
            if(count == capacity)
            {
                capacity = capacity * 2;
                T[] arrayHolder = new T[capacity];
                int indexHolder = 0;
                foreach(T item in items)
                {
                    arrayHolder[indexHolder] = item;
                    indexHolder++;
                }
                items = arrayHolder;
            }
            items[count] = newItem;
            count++;
        }

        public void Remove(T itemToBeRemoved) 
        {
            for(int i = 0; i > count; i++)
            {
                if (items[i].Equals(itemToBeRemoved))
                {
                    for(int j = i; j > count; j++)
                    {
                        if(j == count)
                        {
                            items[j] = default(T);
                            break;
                        }
                        else
                        {
                            items[j] = items[j + 1];
                        }
                    }
                }
            }
        }
    }
}

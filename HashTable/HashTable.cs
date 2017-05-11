using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableImpl
{
    public class HashTable : IHashTable
    {
        private const uint Capacity = 7;
        private LinkedList<HashTableEntry>[] table = new LinkedList<HashTableEntry>[Capacity];

        private long GetHash(object key)
        {
            return Math.Abs(key.GetHashCode()) % Capacity;
        }

        public object this[object key]
        {
            get
            {
                object value;
                if (TryGet(key, out value)) return value;
                throw new NotImplementedException();
            }

            set
            {
                Add(key, value);
            }
        }

        public void Add(object key, object value)
        {
            var hash = GetHash(key);
            if (table[hash] == null)
            {
                table[hash] = new LinkedList<HashTableEntry>();
            }
            table[hash].AddFirst(new HashTableEntry(key, value));
        }

        public bool Contains(object key)
        {
            var hash = GetHash(key);
            return (table[hash] != null) && (table[hash].Count(p => p.Key == key) > 0);
        }

        public bool TryGet(object key, out object value)
        {
            var hash = GetHash(key);
            value = table[hash]?.FirstOrDefault(p => p.Key == key)?.Value;
            return value != null;
        }
    }
}

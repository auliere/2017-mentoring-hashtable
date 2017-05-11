namespace HashTableImpl
{
    internal class HashTableEntry
    {

        public object Key { get; private set; }
        public object Value;

        public HashTableEntry(object key, object value)
        {
            Key = key;
            Value = value;
        }
    }
}
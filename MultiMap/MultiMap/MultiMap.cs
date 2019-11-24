using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiMap
{
    /// <summary>
    /// A MultiMap generic collection class wich can store more than one value for a Key
    /// </summary>
    /// <typeparam name="TKey"></typeparam>
    /// <typeparam name="TValue"></typeparam>
    public class MultiMap<TKey, TValue> : IDictionary<TKey, List<TValue>>
    {
        public Dictionary<TKey, List<TValue>> MultiMapTenor { get; set; }

        public List<TValue> this[TKey key] { get => this.MultiMapTenor[key]; set => this.MultiMapTenor[key] = value; }

        public ICollection<TKey> Keys { get; set; }

        public ICollection<List<TValue>> Values { get; set; }

        public int Count { get; set; }

        public bool IsReadOnly { get; set; }

        /// <summary>
        /// MultiMap adds an element
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>

        public void Add(TKey key, List<TValue> value)
        {
            this.MultiMapTenor.Add(key, value);
        }

        /// <summary>
        /// Multiap adds an key value
        /// </summary>
        /// <param name="item"></param>
        public void Add(KeyValuePair<TKey, List<TValue>> item)
        {
            this.MultiMapTenor.Add(item.Key,item.Value);
        }

        /// <summary>
        /// Clearing a MutiMap
        /// </summary>

        public void Clear()
        {
            this.MultiMapTenor.Clear();
        }

        /// <summary>
        /// Verifies that MultiMap contains the item
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>

        public bool Contains(KeyValuePair<TKey, List<TValue>> item)
        {
            return this.MultiMapTenor.Contains(item);
        }

        /// <summary>
        /// Verifies that MultiMap contains the key
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool ContainsKey(TKey key)
        {
            return this.MultiMapTenor.Keys.Contains(key);
        }

        /// <summary>
        /// Copies from the specified array index
        /// </summary>
        /// <param name="array"></param>
        /// <param name="arrayIndex"></param>
        public void CopyTo(KeyValuePair<TKey, List<TValue>>[] array, int arrayIndex)
        {
            if (arrayIndex >= 0 && this.MultiMapTenor != null)
            {
                array.Take(arrayIndex).Concat(this.MultiMapTenor);
            }
        }

        public IEnumerator<KeyValuePair<TKey, List<TValue>>> GetEnumerator()
        {
            return this.MultiMapTenor.GetEnumerator();
        }

        /// <summary>
        /// Remove Key in MultiMap
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public bool Remove(TKey key)
        {
           return this.MultiMapTenor.Remove(key);
        }

        /// <summary>
        /// Remove member in MultiMap
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Remove(KeyValuePair<TKey, List<TValue>> item)
        {
            return this.Remove(item);
        }
        /// <summary>
        /// gets the value of MultiMap
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool TryGetValue(TKey key, out List<TValue> value)
        {
            return this.MultiMapTenor.TryGetValue(key, out value );
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        
    }
}

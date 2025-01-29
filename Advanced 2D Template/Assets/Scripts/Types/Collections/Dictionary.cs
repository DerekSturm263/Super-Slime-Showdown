using System;
using System.Collections.Generic;
using UnityEngine;

namespace Types.Collections
{
    [Serializable]
    public class Dictionary<TKey, TValue> : System.Collections.Generic.Dictionary<TKey, TValue>, ISerializationCallbackReceiver
    {
        [SerializeField] private List<Miscellaneous.Tuple<TKey, TValue>> _kvps = new();

        public Dictionary() : base() { }
        public Dictionary(IDictionary<TKey, TValue> dictionary) : base(dictionary) { }

        public void OnBeforeSerialize()
        {
            _kvps.Clear();

            foreach (var kvp in this)
            {
                _kvps.Add(new(kvp.Key, kvp.Value));
            }
        }

        public void OnAfterDeserialize()
        {
            Clear();

            for (int i = 0; i < _kvps.Count; ++i)
            {
                if (_kvps[i].Item1 is null || ContainsKey(_kvps[i].Item1))
                    _kvps[i] = new(PreventDuplicates(), _kvps[i].Item2);

                Add(_kvps[i].Item1, _kvps[i].Item2);
            }
        }

        private TKey PreventDuplicates()
        {
            if (typeof(TKey).IsClass)
            {
                if (typeof(TKey) == typeof(string))
                    return (TKey)("" as object);
                else
                    return (TKey)System.Activator.CreateInstance(typeof(TKey));
            }
            else
            {
                return default;
            }
        }

        public int IndexOf(TKey key)
        {
            Miscellaneous.Tuple<TKey, TValue> list = _kvps.Find(item => item.Item1.Equals(key));
            return _kvps.IndexOf(list);
        }

        public Miscellaneous.Tuple<TKey, TValue> GetFromOrderIndex(int index) => _kvps[index];
    }
}

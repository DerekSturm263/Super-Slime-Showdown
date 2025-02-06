using System;
using UnityEngine;

namespace Types.Miscellaneous
{
    [Serializable]
    public struct SaveData
    {
        [SerializeField] private Collections.Dictionary<string, Any> _data;
        public readonly T Get<T>(string key) => _data[key].Get<T>(); // MODIFIED
    }
}

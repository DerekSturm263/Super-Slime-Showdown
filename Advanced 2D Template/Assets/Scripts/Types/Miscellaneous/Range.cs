using System;
using UnityEngine;

namespace Types.Miscellaneous
{
    [Serializable]
    public struct Range<T>
    {
        [SerializeField] private T _min;
        public readonly T Min => _min;

        [SerializeField] private T _max;
        public readonly T Max => _max;

        public Range(T min, T max)
        {
            _min = min;
            _max = max;
        }
    }
}

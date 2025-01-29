using System;
using UnityEngine;

namespace Types.Miscellaneous
{
    [Serializable]
    public struct Variant<T1, T2>
    {
        [SerializeField] private T1 _value1;
        [SerializeField] private T2 _value2;

        [SerializeField] private int _index;

        public readonly T Get<T>()
        {
            return _index switch
            {
                1 => (T)(object)_value2,
                _ => (T)(object)_value1
            };
        }

        public readonly System.Type GetUnderlyingType()
        {
            return _index switch
            {
                1 => _value2.GetType(),
                _ => _value1.GetType()
            };
        }
    }

    [Serializable]
    public struct Variant<T1, T2, T3>
    {
        [SerializeField] private T1 _value1;
        [SerializeField] private T2 _value2;
        [SerializeField] private T3 _value3;

        [SerializeField] private int _index;

        public readonly T Get<T>()
        {
            return _index switch
            {
                1 => (T)(object)_value2,
                2 => (T)(object)_value3,
                _ => (T)(object)_value1
            };
        }

        public readonly System.Type GetUnderlyingType()
        {
            return _index switch
            {
                1 => _value2.GetType(),
                2 => _value3.GetType(),
                _ => _value1.GetType()
            };
        }
    }

    [Serializable]
    public struct Variant<T1, T2, T3, T4>
    {
        [SerializeField] private T1 _value1;
        [SerializeField] private T2 _value2;
        [SerializeField] private T3 _value3;
        [SerializeField] private T4 _value4;

        [SerializeField] private int _index;

        public readonly T Get<T>()
        {
            return _index switch
            {
                1 => (T)(object)_value2,
                2 => (T)(object)_value3,
                3 => (T)(object)_value4,
                _ => (T)(object)_value1
            };
        }

        public readonly System.Type GetUnderlyingType()
        {
            return _index switch
            {
                1 => _value2.GetType(),
                2 => _value3.GetType(),
                3 => _value4.GetType(),
                _ => _value1.GetType()
            };
        }
    }
}

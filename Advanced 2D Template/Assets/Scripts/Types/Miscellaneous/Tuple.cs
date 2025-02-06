using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Types.Miscellaneous
{
    [Serializable]
    public struct Tuple<T1, T2> : ITuple
    {
        [SerializeField] private T1 _item1;
        public readonly T1 Item1 => _item1;

        [SerializeField] private T2 _item2;
        public readonly T2 Item2 => _item2;

        public Tuple(T1 item1, T2 item2)
        {
            _item1 = item1;
            _item2 = item2;
        }

        public object this[int index]
        {
            readonly get
            {
                return index switch
                {
                    1 => _item2,
                    _ => _item1
                };
            }
            set
            {
                switch (index)
                {
                    case 0:
                        _item1 = (T1)value;
                        break;

                    case 1:
                        _item2 = (T2)value;
                        break;
                }
            }
        }

        public readonly int Length => 2;
    }

    [Serializable]
    public struct Tuple<T1, T2, T3> : ITuple // MODIFIED
    {
        [SerializeField] private T1 _item1;
        public readonly T1 Item1 => _item1;

        [SerializeField] private T2 _item2;
        public readonly T2 Item2 => _item2;

        [SerializeField] private T3 _item3;
        public readonly T3 Item3 => _item3;

        public Tuple(T1 item1, T2 item2, T3 item3)
        {
            _item1 = item1;
            _item2 = item2;
            _item3 = item3;
        }

        public object this[int index]
        {
            readonly get
            {
                return index switch
                {
                    2 => _item3,
                    1 => _item2,
                    _ => _item1
                };
            }
            set
            {
                switch (index)
                {
                    case 0:
                        _item1 = (T1)value;
                        break;

                    case 1:
                        _item2 = (T2)value;
                        break;

                    case 2:
                        _item3 = (T3)value;
                        break;
                }
            }
        }

        public readonly int Length => 3;
    }
}

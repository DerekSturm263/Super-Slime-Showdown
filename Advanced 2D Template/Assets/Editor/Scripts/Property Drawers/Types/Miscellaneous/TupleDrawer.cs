using UnityEditor;

namespace Types.Miscellaneous
{
    [CustomPropertyDrawer(typeof(Tuple<,>))]
    internal class Tuple1Drawer : PropertyDrawerBase
    {
        public override string[][] GetPropertyNames() => new string[][]
        {
            new string[] { "_item1" },
            new string[] { "_item2" }
        };
    }

    [CustomPropertyDrawer(typeof(Tuple<,,>))]
    internal class Tuple2Drawer : PropertyDrawerBase
    {
        public override string[][] GetPropertyNames() => new string[][]
        {
            new string[] { "_item1" },
            new string[] { "_item2" },
            new string[] { "_item3" },
        };
    }
}

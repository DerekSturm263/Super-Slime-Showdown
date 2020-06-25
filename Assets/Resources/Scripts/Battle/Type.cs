using System.Collections.Generic;
using UnityEngine;

public class Type
{
    // I needed to make this so I could test out spawning enemy slimes. Feel free to make any changes to this script if you need to since battle is your territory.

    public string Name;
    public Color TypeColor;

    public List<Type> Weaknesses;
    public List<Type> Resistances;
    public List<Type> Immunities;

    public Type(string name, Color typeColor, List<Type> weaknesses = null, List<Type> resistances = null, List<Type> immunities = null)
    {
        Name = name;
        TypeColor = typeColor;

        Weaknesses = weaknesses;
        Resistances = resistances;
        Immunities = immunities;
    }
}

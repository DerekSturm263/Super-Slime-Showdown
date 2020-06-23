using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Type
{
    public string Name;
    public List<Type> Weaknesses;
    public List<Type> Resistances;
    public List<Type> Immunities;

    public Type(string name, List<Type> weaknesses = null, List<Type> resistances = null, List<Type> immunities = null)
    {
        Name = name;
        Weaknesses = weaknesses;
        Resistances = resistances;
        Immunities = immunities;
    }
}

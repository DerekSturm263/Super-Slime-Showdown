using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{
    public string Name;
    public string Description;
    public Type Type;

    public Ability(string name, string description, Type type)
    {
        Name = name;
        Description = description;
        Type = type;
    }
}

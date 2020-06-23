using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability
{
    // I needed to make this so I could test out spawning enemy slimes. Feel free to make any changes to this script if you need to since battle is your territory.

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

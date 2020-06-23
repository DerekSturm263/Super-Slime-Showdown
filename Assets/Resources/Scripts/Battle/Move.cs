using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    // I needed to make this so I could test out spawning enemy slimes. Feel free to make any changes to this script if you need to since battle is your territory.

    public string Name;
    public string Description;
    public Type Type;
    public float Damage;
    public float EnergyUse;

    public Move(string name, string description, float damage, float energyUse, Type type)
    {
        Name = name;
        Description = description;
        Type = type;
        Damage = damage;
        EnergyUse = energyUse;
    }
}

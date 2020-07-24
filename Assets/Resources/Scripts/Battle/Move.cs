using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Move
{
    public enum Target
    {
        Self, Opponent, Both, Battlefield
    }
    public Target MoveTarget;

    public string Name;
    public string Description;
    public Type Type;
    public float Damage;
    public float EnergyUse;

    public Action extraEffect;

    public Move(string name, string description, float damage, float energyUse, Type type, Target moveTarget = Target.Opponent)
    {
        Name = name;
        Description = description;
        Type = type;
        Damage = damage;
        EnergyUse = energyUse;
        MoveTarget = moveTarget;
    }

    public Color GetColor()
    {
        Color newColor = Type.TypeColor;
        newColor.a = 1f;

        return newColor;
    }
}

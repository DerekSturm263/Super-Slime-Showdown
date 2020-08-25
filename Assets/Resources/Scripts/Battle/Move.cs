using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Move
{
    // Function has no impact on how the move behaves, it is used by the enemy AI to determine what type of move it should use based on the situation.
    public enum Function
    {
        Heal, Block, Restore_Energy, Buff, Give_Status, Attack
    }
    public Function MoveFunction;

    public string Name;
    public string Description;
    public Type Type;
    public float Damage;
    public float EnergyUse;

    public Action ExtraEffect;
    public Action Animation;

    public Move(string name, string description, float damage, float energyUse, Type type, Function moveFunction = Function.Attack)
    {
        Name = name;
        Description = description;
        Type = type;
        Damage = damage;
        EnergyUse = energyUse;
        MoveFunction = moveFunction;
    }

    public Color GetColor()
    {
        Color newColor = Type.TypeColor;
        newColor.a = 1f;

        return newColor;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Move
{
    // Function has no impact on how the move behaves, it is used by the enemy AI to determine what type of move it should use based on the situation.
    public enum Function
    {
        Damage, Heal_HP, Restore_Energy, Buff_Self, Nerf_Opponent, Change_Battlefield, Inflict_Status_Self, Inflict_Status_Opponent
    }
    public Function function;

    public string Name;
    public string Description;
    public Type Type;
    public float Damage;
    public float EnergyUse;

    public Action extraEffect;

    public Move(string name, string description, float damage, float energyUse, Type type)
    {
        Name = name;
        Description = description;
        Type = type;
        Damage = damage;
        EnergyUse = energyUse;
    }

    public BattleEntity GetUser()
    {
        BattleEntity user = null;

        if (BattleManager.battleTurn == BattleManager.BattleTurn.PlayerTurn)
            user = BattleManager.player;
        else if (BattleManager.battleTurn == BattleManager.BattleTurn.EnemyTurn)
            user = BattleManager.enemy;

        return user;
    }

    public Color GetColor()
    {
        Color newColor = Type.TypeColor;
        newColor.a = 1f;

        return newColor;
    }
}

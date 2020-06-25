using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class Enemy
{
    public List<Type> Types = new List<Type>(); // This is the type that is displayed in battle. The player can have up to 2 is they dual type.

    public string Name;
    public uint HPMax;
    public uint HPCurrent;
    public uint EnergyMax;
    public uint EnergyCurrent;
    public float Pow;
    public float Def;
    public float Spd;

    // Overworld stuff.
    public float Size; // Used in overworld for bosses.
    public bool CanMove; // Used in overworld so bosses don't move.

    public Dictionary<Type, float> TypeAffinities = new Dictionary<Type, float>(); // These are the affinities for each type.

    public List<Move> Moves = new List<Move>(); // The entity can have up to 4 moves.
    public Ability Ability;

    public List<TypeCosmetic> TypeCosmetics = new List<TypeCosmetic>(); // The entity can have up to 3 Type Cosmetics displayed at once.
    public ShopCosmetic ShopCosmetic; // The tntity can have 1 Cosmetic that you can buy in a shop.

    public Enemy(string name, uint hp, uint energy, float pow, float def, float spd,
        Dictionary<Type, float> typeAffinities, List<Move> moves, float size = 1f, bool canMove = true, Ability ability = null, List<TypeCosmetic> typeCosmetics = null, ShopCosmetic shopCosmetic = null)
    {
        Name = name;
        HPMax = hp;
        HPCurrent = HPMax;
        EnergyMax = energy;
        EnergyCurrent = EnergyMax;
        Pow = pow;
        Def = def;
        Spd = spd;
        TypeAffinities = typeAffinities;
        Moves = moves;
        Size = size;
        CanMove = canMove;
        Ability = ability;
        TypeCosmetics = typeCosmetics;
        ShopCosmetic = shopCosmetic;

        #region Type Setting

        // The slime can have up to 2 types based on their current affinity. If 1 is higher than the rest,
        // then that is chosen as the slime's typing, if 2 tie, then the slime dual types both those types.

        var typesList = TypeAffinities.ToList();
        typesList.Sort((x, y) => (y.Value.CompareTo(x.Value)));
        typesList.ForEach((x) => Types.Add(x.Key));

        if (typesList.Count > 1)
        {

        }
        else
        {
            
        }

        #endregion
    }
}

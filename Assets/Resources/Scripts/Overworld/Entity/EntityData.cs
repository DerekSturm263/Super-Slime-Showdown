using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityData
{
    private string Name;
    private List<Type> Types = new List<Type>(); // This is the type that is displayed in battle. The player can have up to 2 is they dual type.
    private uint HPMax;
    private uint HPCurrent;
    private uint EnergyMax;
    private uint EnergyCurrent;
    private float Pow;
    private float Def;
    private float Spd;

    private Dictionary<Type, float> TypeAffinities = new Dictionary<Type, float>(); // These are the affinities for each type.

    private List<Move> Moves = new List<Move>(); // The entity can have up to 4 moves.
    private Ability Ability;

    private List<TypeCosmetic> TypeCosmetics = new List<TypeCosmetic>(); // The entity can have up to 3 Type Cosmetics displayed at once.
    private ShopCosmetic ShopCosmetic; // The tntity can have 1 Cosmetic that you can buy in a shop.

    public EntityData(string name, uint hp, uint energy, float pow, float def, float spd,
        Dictionary<Type, float> typeAffinities, List<Move> moves, Ability ability, List<TypeCosmetic> typeCosmetics, ShopCosmetic shopCosmetic)
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
        Ability = ability;
        TypeCosmetics = typeCosmetics;
        ShopCosmetic = shopCosmetic;

        List<float> affinityFloats = new List<float>();
        List<Type> affinityTypes = new List<Type>();
        foreach (KeyValuePair<Type, float> value in typeAffinities)
        {
            affinityFloats.Add(value.Value);
            affinityTypes.Add(value.Key);
        }

        affinityFloats.Sort();
        affinityFloats.Reverse();
    }
}

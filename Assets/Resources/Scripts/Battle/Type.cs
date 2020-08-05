using System.Collections.Generic;
using UnityEngine;

public class Type
{
    // I needed to make this so I could test out spawning enemy slimes. Feel free to make any changes to this script if you need to since battle is your territory.

    public string Name;
    public Color TypeColor;

    public Dictionary<int, Move> LevelUpMoves = new Dictionary<int, Move>();
    public Dictionary<int, Ability> LevelUpAbilities = new Dictionary<int, Ability>();
    public Dictionary<int, TypeCosmetic> LevelUpCosmetics = new Dictionary<int, TypeCosmetic>();

    public List<Type> Weaknesses;
    public List<Type> Resistances;
    public List<Type> Immunities;

    public Stats statBoosts;

    public Type(string name, Color typeColor, uint hpBuff, uint energyBuff, uint powBuff, uint defBuff, uint spdBuff)
    {
        Name = name;
        TypeColor = typeColor;

        statBoosts.HPMax = hpBuff;
        statBoosts.EnergyMax = energyBuff;
        statBoosts.Pow = powBuff;
        statBoosts.Def = defBuff;
        statBoosts.Spd = spdBuff;
    }

    public void SetWeaknesses(List<Type> weaknesses)
    {
        Weaknesses = weaknesses;
    }


    public void SetResistances(List<Type> resistances)
    {
        Resistances = resistances;
    }

    public void SetImmunities(List<Type> immmunities)
    {
        Immunities = immmunities;
    }

    public void SetDictionaries(Dictionary<int, Move> levelUpMoves = null, Dictionary<int, Ability> levelUpAbilities = null, Dictionary<int, TypeCosmetic> levelUpCosmetics = null)
    {
        LevelUpMoves = levelUpMoves;
        LevelUpAbilities = levelUpAbilities;
        LevelUpCosmetics = levelUpCosmetics;
    }
}

using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public static class PlayerInfo
{
    public static bool hasSlime = false;
    public static Vector2 lastPlayerPos = new Vector2(0f, 0f);

    public static uint goldCount = 0;
    public static string playerName = "";

    public static uint HPMax = 20;
    public static uint HPCurrent = 20;

    public static uint EnergyMax = 20;
    public static uint EnergyCurrent = 20;

    public static float Pow = 5f;
    public static float Def = 5f;
    public static float Spd = 5f;

    public static Dictionary<Type, float> typeAffinities = new Dictionary<Type, float>()
    {
        { Types.Nature, 0f },
        { Types.Fire, 0f },
        { Types.Water, 0f },
        { Types.Earth, 0f },
        { Types.Ice, 0f },
        { Types.Volt, 0f },
        { Types.Wind, 0f },
        { Types.Toxin, 0f },
        { Types.Light, 0f },
        { Types.Shadow, 0f }
    };
    public static List<Type> types = new List<Type>(); // Display of types based on highest affinities.

    public static List<Move> ownedMoves = new List<Move>();
    public static List<Move> activeMoves = new List<Move>();

    public static List<Ability> ownedAbilities = new List<Ability>();
    public static Ability activeAbility;

    public static List<Cosmetic> ownedCosmetics = new List<Cosmetic>();
    public static List<Cosmetic> activeCosmetics = new List<Cosmetic>();

    public static List<TypeCosmetic> ownedTypeCosmetics = new List<TypeCosmetic>();
    public static List<TypeCosmetic> activeTypeCosmetics = new List<TypeCosmetic>();

    public static List<Item> inventory = new List<Item>();

    public static void LearnMove(Move m)
    {
        if (ownedMoves.Contains(m))
            return;

        ownedMoves.Add(m);
        Debug.Log("Player learned " + m.Name + ".");

        // Adds the move to the closest open active spot in the active moves list.
        if (activeMoves.Count < 4) SetMove(m);
    }

    public static void SetMove(Move m)
    {
        if (activeMoves.Contains(m))
            return;

        activeMoves.Add(m);
    }

    public static void RemoveMove(Move m)
    {
        if (activeMoves.Count == 1)
            return;

        if (activeMoves.Contains(m)) activeMoves.Remove(m);
    }

    public static void RemoveMove(int i)
    {
        if (activeMoves.Count == 1)
            return;

        if (activeMoves[i] != null) activeMoves.RemoveAt(i);
    }

    public static void LearnAbility(Ability a)
    {
        if (ownedAbilities.Contains(a))
            return;

        ownedAbilities.Add(a);
        Debug.Log("Player learned " + a.Name + ".");

        // Adds the ability if there is no ability set.
        if (activeAbility != null) SetAbility(a);
    }

    public static void SetAbility(Ability a)
    {
        if (activeAbility == a)
            return;

        activeAbility = a;
    }

    public static void RemoveAbility(Ability a)
    {
        if (activeAbility == a) activeAbility = null;
    }

    public static void RemoveAbility()
    {
        if (activeAbility == null)
            return;

        activeAbility = null;
    }

    public static void GrowCosmetic(TypeCosmetic c)
    {
        if (ownedTypeCosmetics.Contains(c))
            return;

        // Adds the cosmetic to the closest open active spot in the active cosmetics list.
        if (activeTypeCosmetics.Count < 3) SetTypeCosmetic(c);
    }

    public static void SetTypeCosmetic(TypeCosmetic c)
    {
        if (activeTypeCosmetics.Contains(c))
            return;

        activeTypeCosmetics.Add(c);
    }

    public static void SetShopCosmetic(Cosmetic c)
    {
        if (activeCosmetics.Contains(c))
            return;

        activeCosmetics.Add(c);
    }

    public static void RemoveCosmetic(Cosmetic c)
    {
        if (activeCosmetics.Contains(c)) activeCosmetics.Remove(c);
    }

    public static void RemoveCosmetic(int i)
    {
        if (activeCosmetics[i] != null) activeCosmetics.RemoveAt(i);
    }

    public static void RaiseAffinity(Type t, float amount)
    {
        typeAffinities[t] += amount;
        Debug.Log("Player raised their " + t.Name + " affinity by " + amount + ".");

        // Iterates through every level if the user levels up by more than one.
        for (int i = (int) (typeAffinities[t] - amount + 1); i <= (int) typeAffinities[t]; i++)
        {
            // Tries to learn a new move.
            try
            {
                LearnMove(t.LevelUpMoves[i]);
            } catch { }

            // Tries to learn a new ability.
            try
            {
                LearnAbility(t.LevelUpAbilities[i]);
            }
            catch { }

            // Tries to grow a new cosmetic change.
            try
            {
                GrowCosmetic(t.LevelUpCosmetics[i]);
            }
            catch { }
        }

        // Update type.
        types.Clear();

        var typesList = typeAffinities.ToList();
        typesList.Sort((x, y) => (y.Value.CompareTo(x.Value)));
        float highestAffinity = typesList[0].Value;
        typesList.FindAll(x => x.Value == highestAffinity)
            .ForEach(x => types.Add(x.Key));
    }
}
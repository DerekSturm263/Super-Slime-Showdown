using System.Collections.Generic;

public static class PlayerInfo
{
    public static bool hasSlime;

    public static uint goldCount;
    public static string playerName;

    public static uint HPMax;
    public static uint HPCurrent;

    public static uint EnergyMax;
    public static uint EnergyCurrent;

    public static float Pow;
    public static float Def;
    public static float Spd;

    public static Dictionary<Type, float> typeAffinities = new Dictionary<Type, float>();
    public static List<Type> types = new List<Type>();

    public static List<Move> ownedMoves = new List<Move>();
    public static List<Move> activeMoves = new List<Move>();

    public static List<Ability> ownedAbilities = new List<Ability>();
    public static Ability activeAbility;

    public static List<Cosmetic> ownedCosmetics = new List<Cosmetic>();
    public static List<Cosmetic> activeCosmetics = new List<Cosmetic>();

    public static List<TypeCosmetic> ownedTypeCosmetics = new List<TypeCosmetic>();
    public static List<TypeCosmetic> activeTypeCosmetics = new List<TypeCosmetic>();

    public static List<Item> inventory = new List<Item>();
}

using System.Collections.Generic;

public static class PlayerInfo
{
    public static bool hasSlime = false;

    public static uint goldCount = 0;
    public static string playerName = "";

    public static uint HPMax = 20;
    public static uint HPCurrent = 20;

    public static uint EnergyMax = 20;
    public static uint EnergyCurrent = 20;

    public static float Pow = 5;
    public static float Def = 5;
    public static float Spd = 5;

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

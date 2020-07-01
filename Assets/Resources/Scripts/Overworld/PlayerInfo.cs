using System.Collections.Generic;

public static class PlayerInfo
{
    public static bool hasSlime;

    public static uint goldCount;
    public static string playerName;

    public static Dictionary<Type, float> typeAffinities = new Dictionary<Type, float>();
    public static List<Type> types = new List<Type>();

    public static List<Move> ownedMoves = new List<Move>();
    public static List<Move> activeMoves = new List<Move>();

    public static List<Ability> ownedAbilities = new List<Ability>();
    public static Ability activeAbility;

    public static List<TypeCosmetic> ownedCosmetics = new List<TypeCosmetic>();
    public static List<TypeCosmetic> activeTypeCosmetics = new List<TypeCosmetic>();

    public static List<Item> inventory = new List<Item>();
}

using System;
using System.Collections;
using System.Collections.Generic;

public static class PlayerInfo
{
    public static uint goldCount;

    public static Dictionary<Type, float> typeAffinities = new Dictionary<Type, float>();
    public static List<Type> types = new List<Type>();

    public static List<Move> allMoves = new List<Move>();
    public static List<Move> activeMoves = new List<Move>();

    public static List<Ability> allAbilities = new List<Ability>();
    public static Ability activeAbility;

    public static List<ShopCosmetic> allShopCosmetics;
    public static ShopCosmetic activeShopCosmetic;

    public static List<TypeCosmetic> allTypeCosmetics = new List<TypeCosmetic>();
    public static List<TypeCosmetic> activeTypeCosmetics = new List<TypeCosmetic>();
}

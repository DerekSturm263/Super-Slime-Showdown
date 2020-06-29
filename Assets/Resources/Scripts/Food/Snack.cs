using UnityEngine;

public class Snack
{
    public string Name;
    public string Description;
    public uint Cost;

    public Sprite Image;

    public Type SnackType;

    public float StrengthMultiplier;
    public uint HealAmount;
    public uint EnergyHealAmount;
    public uint BuffedTurns;

    public Snack(string name, string description, uint cost, Sprite image, Type snackType, float strengthMultiplier, uint healAmount, uint energyHealAmount, uint buffedTurns)
    {
        Name = name;
        Description = description;
        Cost = cost;
        Image = image;
        SnackType = snackType;
        StrengthMultiplier = strengthMultiplier;
        HealAmount = healAmount;
        EnergyHealAmount = energyHealAmount;
        BuffedTurns = buffedTurns;
    }
}

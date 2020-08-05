using UnityEngine;

public class Snack : Item
{
    public Type SnackType;

    public float StrengthMultiplier;
    public uint HealAmount;
    public uint EnergyHealAmount;
    public uint BuffedTurns;

    public Snack(string itemName, Sprite icon, string description, uint cost) : base (itemName, icon, description, cost)
    {

    }
}

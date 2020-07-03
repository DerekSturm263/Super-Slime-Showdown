using UnityEngine;

public class Types
{
    // I left a lot of this stuff blank until we get battles working. We will need to add weaknesses, resistances, and immunities.

    public static readonly Type Typeless = new Type("Typeless", new Color(1f, 1f, 1f, 0.9f));
    public static readonly Type Nature = new Type("Nature", new Color(0.2559f, 1f, 0.25f, 0.9f));
    public static readonly Type Water = new Type("Water", new Color(0.25f, 0.75f, 1f, 0.9f));
    public static readonly Type Fire = new Type("Fire", new Color(0.9f, 0.5631f, 0.2252f, 0.9f));
    public static readonly Type Ice = new Type("Ice", new Color(0f, 1f, 1f, 0.9f));
    public static readonly Type Earth = new Type("Earth", new Color(0.75f, 0.75f, 0.375f, 0.9f));
    public static readonly Type Volt = new Type("Volt", new Color(1f, 1f, 0f, 0.9f));
    public static readonly Type Wind = new Type("Wind", new Color(1f, 0.504f, 0.752f, 0.9f));
    public static readonly Type Toxin = new Type("Toxin", new Color(0.8187f, 0.405f, 0.9f, 0.9f));
    public static readonly Type Light = new Type("Light", new Color(1f, 1f, 0.75f, 0.9f));
    public static readonly Type Shadow = new Type("Shadow", new Color(0f, 0f, 0f, 0.9f));
}

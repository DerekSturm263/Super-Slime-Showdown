using UnityEngine;

public class Types
{
    // I left a lot of this stuff blank until we get battles working. We will need to add weaknesses, resistances, and immunities.

    public static readonly Type Typeless = new Type("Typeless", Color.white);
    public static readonly Type Nature = new Type("Nature", Color.green);
    public static readonly Type Water = new Type("Water", Color.blue);
    public static readonly Type Fire = new Type("Fire", Color.red);
    public static readonly Type Ice = new Type("Ice", Color.cyan);
    public static readonly Type Earth = new Type("Earth", new Color(0f, 0.3f, 0.1f));
    public static readonly Type Volt = new Type("Volt", Color.yellow);
    public static readonly Type Wind = new Type("Wind", new Color(0.6f, 1f, 0.8f));
    public static readonly Type Toxin = new Type("Toxin", Color.magenta);
    public static readonly Type Light = new Type("Light", new Color(0.6f, 1f, 0.5f));
    public static readonly Type Shadow = new Type("Shadow", Color.black);
}

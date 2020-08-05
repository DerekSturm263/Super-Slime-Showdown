using System.Collections.Generic;
using UnityEngine;

public static class Types
{
    public static Type Typeless = new Type("Typeless", new Color(1f, 1f, 1f, 0.9f), 0, 0, 0, 0, 0); // 0 total.
    public static Type Nature = new Type("Nature", new Color(0.2559f, 1f, 0.25f, 0.9f), 3, 3, 1, 2, 1); // 10 total.
    public static Type Water = new Type("Water", new Color(0.25f, 0.75f, 1f, 0.9f), 2, 2, 3, 2, 1); // 10 total.
    public static Type Fire = new Type("Fire", new Color(0.9f, 0.5631f, 0.2252f, 0.9f), 1, 2, 3, 3, 1); // 10 total.
    public static Type Ice = new Type("Ice", new Color(0f, 1f, 1f, 0.9f), 3, 1, 2, 3, 2); // 11 total.
    public static Type Earth = new Type("Earth", new Color(0.75f, 0.75f, 0.375f, 0.9f), 2, 1, 3, 3, 1); // 10 total.
    public static Type Volt = new Type("Volt", new Color(1f, 1f, 0f, 0.9f), 1, 1, 3, 3, 2); // 10 total.
    public static Type Wind = new Type("Wind", new Color(1f, 0.504f, 0.752f, 0.9f), 2, 1, 2, 1, 3); // 9 total.
    public static Type Toxin = new Type("Toxin", new Color(0.8187f, 0.405f, 0.9f, 0.9f), 1, 3, 3, 3, 1); // 11 total.
    public static Type Light = new Type("Light", new Color(1f, 1f, 0.75f, 0.9f), 3, 1, 3, 1, 3); // 10 total.
    public static Type Shadow = new Type("Shadow", new Color(0f, 0f, 0f, 0.9f), 2, 2, 2, 2, 2); // 10 total.

    public static void Initialize()
    {
        // Nature type dictionaries.

        Nature.SetDictionaries(
            new Dictionary<int, Move>
            {
                { 1, Moves.Heal },
                { 3, Moves.Uproot },
                { 8, Moves.Grow },
                { 12, Moves.SawgrassSlice },
                { 20, Moves.ProtectionLeaf },
                { 25, Moves.TwistingVines }
            },
            new Dictionary<int, Ability>
            {
                { 5, Abilities.HealingFactor },
                { 16, Abilities.Rooted },
                { 30, Abilities.Photosynthesis }
            },
            new Dictionary<int, TypeCosmetic>
            {

            }
        );
        Nature.SetWeaknesses(
            new List<Type>
            {
                Fire, Volt
            }
        );
        Nature.SetResistances(
            new List<Type>
            {
                Water, Wind
            }
        );
        Nature.SetImmunities(
            new List<Type>
            {
                Toxin
            }
        );

        // Water type dictionaries.

        Water.SetDictionaries(
            new Dictionary<int, Move>
            {
                { 1, Moves.Splash },
                { 3, Moves.Downpour },
                { 8, Moves.Rehydrate },
                { 12, Moves.Waterball },
                { 20, Moves.Aquify },
                { 25, Moves.Absorption }
            },
            new Dictionary<int, Ability>
            {
                { 5, Abilities.Gills },
                { 16, Abilities.FastSwimmer },
                { 30, Abilities.Waterlog }
            },
            new Dictionary<int, TypeCosmetic>
            {

            }
        );
        Water.SetWeaknesses(
            new List<Type>
            {
                Nature, Volt
            }
        );
        Water.SetResistances(
            new List<Type>
            {
                Fire, Ice
            }
        );
        Water.SetImmunities(
            new List<Type>
            {
                Light
            }
        );

        // Fire type dictionaries.

        Fire.SetDictionaries(
            new Dictionary<int, Move>
            {
                { 1, Moves.Firebreath },
                { 3, Moves.FlameShot },
                { 8, Moves.HeatUp},
                { 12, Moves.Fireball },
                { 20, Moves.ScorchingSlap },
                { 25, Moves.FlashFire }
            },
            new Dictionary<int, Ability>
            {
                { 5, Abilities.HotToTheTouch },
                { 16, Abilities.BurnOut },
                { 30, Abilities.FirstDegreeBurn }
            },
            new Dictionary<int, TypeCosmetic>
            {

            }
        );
        Fire.SetWeaknesses(
             new List<Type>
             {
                 Water, Earth
             }
         );
        Fire.SetResistances(
            new List<Type>
            {
                Nature, Shadow
            }
        );
        Fire.SetImmunities(
            new List<Type>
            {
                Ice
            }
        );

        // Ice type dictionaries.

        Ice.SetDictionaries(
            new Dictionary<int, Move>
        {
            { 1, Moves.FrozenTap },
            { 3, Moves.IceTackle },
            { 8, Moves.Freeze },
            { 12, Moves.IcicleShot },
            { 20, Moves.BuildingIce },
            { 25, Moves.Icebreath }
        },
            new Dictionary<int, Ability>
        {
            { 5, Abilities.WeakIce },
            { 16, Abilities.StrongIce },
            { 30, Abilities.ColdToTheTouch }
        },
            new Dictionary<int, TypeCosmetic>
        {

        }
        );
        Ice.SetWeaknesses(
            new List<Type>
            {
                Fire, Light
            }
        );
        Ice.SetResistances(
            new List<Type>
            {
                Water, Nature
            }
        );
        Ice.SetImmunities(
            new List<Type>
            {
                Earth
            }
        );

        // Earth type dictionaries.

        Earth.SetDictionaries(
            new Dictionary<int, Move>
        {
            { 1, Moves.PebbleToss },
            { 3, Moves.MudShot },
            { 8, Moves.SeismicSmash },
            { 12, Moves.Landslide },
            { 20, Moves.EarthMove5 },
            { 25, Moves.EarthMove6 }
        },
            new Dictionary<int, Ability>
        {
            { 5, Abilities.Aseismic },
            { 16, Abilities.EarthAbility2 },
            { 30, Abilities.EarthAbility3 }
        },
            new Dictionary<int, TypeCosmetic>
        {

        }
        );

        // Volt type dictionaries.

        Volt.SetDictionaries(
            new Dictionary<int, Move>
        {
            { 1, Moves.ZippityZap },
            { 3, Moves.Charge },
            { 8, Moves.Thundershock },
            { 12, Moves.StaticSlam },
            { 20, Moves.ElectroPulse },
            { 25, Moves.Resistor }
        },
            new Dictionary<int, Ability>
        {
            { 5, Abilities.Ampacity },
            { 16, Abilities.ClosedCircuit },
            { 30, Abilities.ExtraVoltage }
        },
            new Dictionary<int, TypeCosmetic>
        {

        }
        );

        // Wind type dictionaries.

        Wind.SetDictionaries(
            new Dictionary<int, Move>
        {
            { 1, Moves.GentleBreeze },
            { 3, Moves.WindCutter },
            { 8, Moves.JetStream },
            { 12, Moves.WindMove4 },
            { 20, Moves.WindMove5 },
            { 25, Moves.WindMove6 }
        },
            new Dictionary<int, Ability>
        {
            { 5, Abilities.Crosswind },
            { 16, Abilities.WindAbility2 },
            { 30, Abilities.WindAbility3 }
        },
            new Dictionary<int, TypeCosmetic>
        {

        }
        );

        // Toxin type dictionaries.

        Toxin.SetDictionaries(
            new Dictionary<int, Move>
        {
            { 1, Moves.PoisonSpit },
            { 3, Moves.ToxicBlock },
            { 8, Moves.VenomousStrike },
            { 12, Moves.ToxinMove4 },
            { 20, Moves.PoisonPummel },
            { 25, Moves.ToxinMove6 }
        },
            new Dictionary<int, Ability>
        {
            { 5, Abilities.PoisonousSkin },
            { 16, Abilities.Antidote },
            { 30, Abilities.DeadlyPoison }
        },
            new Dictionary<int, TypeCosmetic>
        {

        }
        );

        // Light type dictionaries.

        Light.SetDictionaries(
            new Dictionary<int, Move>
        {
            { 1, Moves.HeavenlyRestore },
            { 3, Moves.HaloHop },
            { 8, Moves.SavingGrace },
            { 12, Moves.ShiningStrike },
            { 20, Moves.LightMove5 },
            { 25, Moves.LightMove6 }
        },
            new Dictionary<int, Ability>
        {
            { 5, Abilities.LightAbility1 },
            { 16, Abilities.LightAbility2 },
            { 30, Abilities.GuidingLight }
        },
            new Dictionary<int, TypeCosmetic>
        {

        }
        );

        // Shadow type dictionaries.

        Shadow.SetDictionaries(
            new Dictionary<int, Move>
        {
            { 1, Moves.Backstab },
            { 3, Moves.UmbraSlash },
            { 8, Moves.LifeSteal },
            { 12, Moves.Curse },
            { 20, Moves.Nightmare },
            { 25, Moves.EvilPlan }
        },
            new Dictionary<int, Ability>
        {
            { 5, Abilities.DarkCloud },
            { 16, Abilities.Deception },
            { 30, Abilities.Cheater }
        },
            new Dictionary<int, TypeCosmetic>
        {

        }
        );
    }
}

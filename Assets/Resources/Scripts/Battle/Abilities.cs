using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Abilities
{
    // Nature abilities.
    public static Ability HealingFactor; // Unlock the ability through leveling.
    public static Ability Rooted; // Unlock the ability through leveling.
    public static Ability Photosynthesis; // Unlock the ability through leveling.
    public static Ability NaturesBlessing; // Find the ability in the overworld.
    public static Ability Fertilize; // Unlock by beating a boss.

    // Water abilities.
    public static Ability Gills; // Unlock the ability through leveling.
    public static Ability FastSwimmer; // Unlock the ability through leveling.
    public static Ability WaterAbility3; // Unlock the ability through leveling.
    public static Ability WaterAbility4; // Find the ability in the overworld.
    public static Ability RainDance; // Unlock by beating a boss.

    // Fire abilities.
    public static Ability HotToTheTouch; // Unlock the ability through leveling.
    public static Ability WhiteHotFlame; // Unlock the ability through leveling.
    public static Ability FireAbility3; // Unlock the ability through leveling.
    public static Ability FireAbility4; // Find the ability in the overworld.
    public static Ability FireAbility5; // Unlock by beating a boss.

    // Ice abilities.
    public static Ability ColdToTheTouch; // Unlock the ability through leveling.
    public static Ability WeakIce; // Unlock the ability through leveling.
    public static Ability StrongIce; // Unlock the ability through leveling.
    public static Ability Permafrost; // Find the ability in the overworld.
    public static Ability Blizzard; // Unlock by beating a boss.

    // Earth abilities.
    public static Ability Aseismic; // Unlock the ability through leveling.
    public static Ability EarthAbility2; // Unlock the ability through leveling.
    public static Ability EarthAbility3; // Unlock the ability through leveling.
    public static Ability EarthAbility4; // Find the ability in the overworld.
    public static Ability DustDevil; // Unlock by beating a boss.

    // Volt abilities.
    public static Ability Ampacity; // Unlock the ability through leveling.
    public static Ability ClosedCircuit; // Unlock the ability through leveling.
    public static Ability ExtraVoltage; // Unlock the ability through leveling.
    public static Ability Conductor; // Find the ability in the overworld.
    public static Ability StaticElectricity; // Unlock by beating a boss.

    // Wind abilities.
    public static Ability Crosswind; // Unlock the ability through leveling.
    public static Ability WindAbility2; // Unlock the ability through leveling.
    public static Ability WindAbility3; // Unlock the ability through leveling.
    public static Ability WindAbility4; // Find the ability in the overworld.
    public static Ability Twister; // Unlock by beating a boss.

    // Toxin abilities.
    public static Ability Antidote; // Unlock the ability through leveling.
    public static Ability PoisonousSkin; // Unlock the ability through leveling.
    public static Ability DeadlyPoison; // Unlock the ability through leveling.
    public static Ability ToxinAbility4; // Find the ability in the overworld.
    public static Ability ToxinAbility5; // Unlock by beating a boss.

    // Light abilities.
    public static Ability LightAbility1; // Unlock the ability through leveling.
    public static Ability LightAbility2; // Unlock the ability through leveling.
    public static Ability GuidingLight; // Unlock the ability through leveling.
    public static Ability LightAbility4; // Find the ability in the overworld.
    public static Ability LightAbility5; // Unlock by beating a boss.

    // Shadow abilities.
    public static Ability DarkCloud; // Unlock the ability through leveling.
    public static Ability Deception; // Unlock the ability through leveling.
    public static Ability Cheater; // Unlock the ability through leveling.
    public static Ability InTheShadows; // Find the ability in the overworld.
    public static Ability DarknessCloak; // Unlock by beating a boss.

    public static void Initialize()
    {
        HealingFactor = new Ability("Healing Factor", "The user heals a low amount each turn.", Types.Nature); // Every turn, the user heals back 15% of their HP.
        Rooted = new Ability("Rooted", "The user restores a low amount of Energy every turn, but their speed is halved.", Types.Nature); // Every turn, the user heals back 15% of their Energy, an their speed becomes halved.
        Photosynthesis = new Ability("Photosynthesis", "The user restores a decent amount of Energy whenever they are hit by a light type move.", Types.Nature); // The user heals back 20% of their energy whenever hit by a light type move.
        NaturesBlessing = new Ability("Nature's Blessing", "If the user uses a nature type move, they have a chance to become Blessed.", Types.Nature);
        Fertilize = new Ability("Fertilize", "If the user uses a nature type move, the battlefield will become overgrown.", Types.Nature);

        Gills = new Ability("Gills", "The user heals a low amount of they are hit with a water type move.", Types.Water); // The user heals back 20% of their HP if they are hit by a water type move.
        FastSwimmer = new Ability("Fast Swimmer", "If the user is underwater, their speed is doubled.", Types.Water); // If the battlefield is underwater, the user's speed is doubled.
        WaterAbility3 = new Ability("Water Ability 3", "", Types.Water);
        WaterAbility4 = new Ability("Water Ability 4", "", Types.Water);
        RainDance = new Ability("Rain Dance", "If the user uses a water type move, rain will begin to fall.", Types.Water); // If the user uses a water type move, the battlefield will have the Rain effect.

        HotToTheTouch = new Ability("Hot To The Touch", "If the user is hit with a weak fire type move, attacker is burned.", Types.Fire); // If the user is hit by a fire type move that deals less than 20% of their total HP, the attacker gets the Burn effect.
        WhiteHotFlame = new Ability("White Hot Flame", "Any burns on an opponent caused by the user deal extra damage.", Types.Fire); // If the user burns the opponent, the opponent will take 50% more damage from their burn.
        FireAbility3 = new Ability("Fire Ability 3", "", Types.Fire);
        FireAbility4 = new Ability("Fire Ability 4", "", Types.Fire);
        FireAbility5 = new Ability("Fire Ability 5", "If the user uses a fire type move, the battlefield will become scorching hot.", Types.Fire); // If the user uses a fire type move, the battlefield will have the Scorching Hot effect.

        ColdToTheTouch = new Ability("Cold To The Touch", "If the user would become frozen, the attacker will become frozen instead.", Types.Ice); // If the user would become frozen by a move used by another slime, the slime who would've frozen the user becomes frozen instead.
        WeakIce = new Ability("Weak Ice", "If the user freezes the opponent, the opponent takes more damage from attacks than usual when frozen.", Types.Ice); // If the user freezes the opponent, they take 50% more damage than they usually would when frozen. (When a slime is frozen, they take 50% less damage from attacks.)
        StrongIce = new Ability("Strong Ice", "If the user is frozen, they take less damage than usual when frozen.", Types.Ice); // If the user is frozen, they take 50% less damage than they usually would when frozen.
        Permafrost = new Ability("Permafrost", "If the user would freeze the opponent, the opponent instead takes extra damage from the attack.", Types.Ice); // If the user uses an attack that successfully freezes the opponent, instead of becoming frozen, the opponent takes 100% extra damage.
        Blizzard = new Ability("Blizzard", "If the user uses an ice type move, snow will begin to fall.", Types.Ice); // If the user uses an ice type move, the battlefield will have the Snow effect.

        Aseismic = new Ability("Aseismic", "On the first turn, the user's earth type moves deal extra damage. The user will also take 0.75x from earth type moves.", Types.Earth);
        EarthAbility2 = new Ability("Earth Ability 2", "", Types.Earth);
        EarthAbility3 = new Ability("Earth Ability 3", "", Types.Earth);
        EarthAbility4 = new Ability("Earth Ability 4", "", Types.Earth);
        DustDevil = new Ability("Dust Devil", "If the user uses an earth type move, a sandstorm will kick up.", Types.Earth);

        Ampacity = new Ability("Ampacity", "All volt type move sused by the user use less energy.", Types.Volt);
        ClosedCircuit = new Ability("Closed Circuit", "If the user is hit by a volt type move, the attacker receives a low amount of damage.", Types.Volt);
        ExtraVoltage = new Ability("Extra Voltage", "If the user shocks the opponent, the opponent takes extra damage.", Types.Volt);
        Conductor = new Ability("Conductor", "If there's an electrical storm, the user's volt type moves deal extra damage.", Types.Volt);
        StaticElectricity = new Ability("Static Electricity", "If the user uses a volt type move, an electrical storm will brew.", Types.Volt);

        Crosswind = new Ability("Crosswind", "The turn order is reversed for all slimes in combat.", Types.Wind);
        WindAbility2 = new Ability("Wind Ability 2", "", Types.Wind);
        WindAbility3 = new Ability("Wind Ability 3", "", Types.Wind);
        WindAbility4 = new Ability("Wind Ability 4", "", Types.Wind);
        Twister = new Ability("Twister", "If the user uses a wind type move, the battlefield will become windy.", Types.Wind);

        Antidote = new Ability("Anidote", "The user can't become poisoned.", Types.Toxin);
        PoisonousSkin = new Ability("Poisonous Skin", "If the user is damaged, the attacker has a small chance to become poisoned.", Types.Toxin);
        DeadlyPoison = new Ability("Deadly Poison", "All poison caused by the user deals extra damage.", Types.Toxin);
        ToxinAbility4 = new Ability("Toxin Ability 4", "If the user becomes poisoned, they deal extra damage when attacking.", Types.Toxin);
        ToxinAbility5 = new Ability("Toxin Ability 5", "If the user uses a poison type move, the battlefield will become drenched in poison.", Types.Toxin);

        LightAbility1 = new Ability("Light Ability 1", "All moves used by the user deal a little extra damage to the opponent.", Types.Light);
        LightAbility2  = new Ability("Light Ability 2", "If the user blinds the opponent, the opponent has a higher chance to miss.", Types.Light);
        GuidingLight = new Ability("Guiding Light", "The opponent's ability becomes visible to the player.", Types.Light);
        LightAbility4  = new Ability("Light Ability 4", "", Types.Light);
        LightAbility5  = new Ability("Light Ability 5", "If the user uses a light type move, the battlefield will become very bright.", Types.Light);

        DarkCloud = new Ability("Dark Cloud", "The opponent's moves have a low chance of missing the user.", Types.Shadow);
        Deception = new Ability("Deception", "If the user is forced to reveal their ability, they will display a different one instead.", Types.Shadow);
        Cheater = new Ability("Cheater", "All status effects inflicted upon the user are less effective.", Types.Shadow);
        InTheShadows = new Ability("In The Shadows", "Dark type moves used against the user deal less damage.", Types.Shadow);
        DarknessCloak = new Ability("Darkness Cloak", "If the user uses a dark type move, the battlefield will become shrouded in darkness.", Types.Shadow);
    }
}

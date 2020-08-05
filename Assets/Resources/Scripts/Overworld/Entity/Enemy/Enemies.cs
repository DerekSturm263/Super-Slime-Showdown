using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    // Grass type enemies.
    public static Enemy Acorn = new Enemy("Acorn", 16, 22, 6f, 4f, 4f,
        new Dictionary<Type, float>()
        {
            [Types.Nature] = 1f
        },
        Abilities.HealingFactor, 3);
    
    public static Enemy Herb = new Enemy("Herb", 16, 22, 6f, 4f, 4f,
        new Dictionary<Type, float>()
        {
            [Types.Nature] = 1f
        },
        Abilities.Photosynthesis, 3);

    public static Enemy Peanut = new Enemy("Peanut", 16, 22, 6f, 4f, 4f,
        new Dictionary<Type, float>()
        {
            [Types.Nature] = 1f
        },
        Abilities.Rooted, 3);

    public static Enemy Daisy = new Enemy("Daisy", 16, 22, 6f, 4f, 4f,
        new Dictionary<Type, float>()
        {
            [Types.Nature] = 1f
        },
        Abilities.NaturesBlessing, 3);

    public static Enemy Iris = new Enemy("Iris", 16, 22, 6f, 4f, 4f,
        new Dictionary<Type, float>()
        {
            [Types.Nature] = 1f
        },
        Abilities.HealingFactor, 3);

    // Ice type enemies.
    public static Enemy Frost = new Enemy("Frost", 16, 22, 4f, 6f, 4f,
        new Dictionary<Type, float>()
        {
            [Types.Ice] = 1f
        },
        Abilities.ColdToTheTouch, 3);

    public static Enemy Snowflake = new Enemy("Snowflake", 16, 22, 4f, 6f, 4f,
        new Dictionary<Type, float>()
        {
            [Types.Ice] = 1f
        },
        Abilities.WeakIce, 3);

    public static Enemy Winter = new Enemy("Winter", 16, 22, 4f, 6f, 4f,
        new Dictionary<Type, float>()
        {
            [Types.Ice] = 1f
        },
        Abilities.StrongIce, 3);

    public static Enemy IceEnemy4 = new Enemy("Ice Enemy 4", 16, 22, 4f, 6f, 4f,
        new Dictionary<Type, float>()
        {
            [Types.Ice] = 1f
        },
        Abilities.Permafrost, 3);

    public static Enemy IceEnemy5 = new Enemy("Ice Enemy 5", 16, 22, 4f, 6f, 4f,
        new Dictionary<Type, float>()
        {
            [Types.Ice] = 1f
        },
        Abilities.WeakIce, 3);

    // Bosses.
    public static Enemy NatureBoss = new Enemy("Nature Boss", 200, 100, 20f, 20f, 10f,
        new Dictionary<Type, float>()
        {
            [Types.Nature] = 10f
        },
        Abilities.Rooted, 1, 2.5f, false); // Size & CanMove.

    public static Enemy IceBoss = new Enemy("Ice Boss", 200, 100, 20f, 20f, 10f,
        new Dictionary<Type, float>()
        {
            [Types.Ice] = 10f
        },
        Abilities.StrongIce, 1, 2.5f, false);

    public static void Initialize()
    {
        // Acorn.
        Acorn.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.Uproot
        };
        Acorn.Level2Moves = new List<Move>()
        {
            Moves.Roll, Moves.Heal, Moves.Uproot
        };
        Acorn.Level3Moves = new List<Move>()
        {
            Moves.Roll, Moves.Heal, Moves.Uproot
        };
        Acorn.Level4Moves = new List<Move>()
        {
            Moves.Roll, Moves.Heal, Moves.Uproot, Moves.SawgrassSlice
        };
        Acorn.Level5Moves = new List<Move>()
        {
            Moves.Roll, Moves.SuperHeal, Moves.SawgrassSlice, Moves.TwistingVines
        };
        Acorn.SetDrops(new List<Ingredient> { Ingredients.Oats, Ingredients.Sugar } );

        // Herb.
        Herb.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.Heal
        };
        Herb.Level2Moves = new List<Move>()
        {
            Moves.Roll, Moves.Heal, Moves.Grow
        };
        Herb.Level3Moves = new List<Move>()
        {
            Moves.Roll, Moves.Heal, Moves.Grow
        };
        Herb.Level4Moves = new List<Move>()
        {
            Moves.Roll, Moves.Grow, Moves.SawgrassSlice, Moves.ProtectionLeaf
        };
        Herb.Level5Moves = new List<Move>()
        {
            Moves.Roll, Moves.Grow, Moves.SuperHeal, Moves.TwistingVines
        };
        Herb.SetDrops(new List<Ingredient> { Ingredients.Wheat, Ingredients.Rice });

        // Peanut.
        Peanut.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.Grow
        };
        Peanut.Level2Moves = new List<Move>()
        {
            Moves.Roll, Moves.Grow, Moves.SawgrassSlice
        };
        Peanut.Level3Moves = new List<Move>()
        {
            Moves.Roll, Moves.Grow, Moves.SawgrassSlice
        };
        Peanut.Level4Moves = new List<Move>()
        {
            Moves.Roll, Moves.Grow, Moves.SawgrassSlice, Moves.Heal
        };
        Peanut.Level5Moves = new List<Move>()
        {
            Moves.Roll, Moves.SawgrassSlice, Moves.Heal, Moves.TwistingVines
        };
        Peanut.SetDrops(new List<Ingredient> { Ingredients.Lettuce, Ingredients.Sugar });

        // Daisy.
        Daisy.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.Heal
        };
        Daisy.Level2Moves = new List<Move>()
        {
            Moves.Roll, Moves.Heal, Moves.SawgrassSlice
        };
        Daisy.Level3Moves = new List<Move>()
        {
            Moves.Roll, Moves.Heal, Moves.SawgrassSlice
        };
        Daisy.Level4Moves = new List<Move>()
        {
            Moves.Roll, Moves.Heal, Moves.SawgrassSlice, Moves.ProtectionLeaf
        };
        Daisy.Level5Moves = new List<Move>()
        {
            Moves.Roll, Moves.Heal, Moves.TwistingVines, Moves.ProtectionLeaf
        };
        Daisy.SetDrops(new List<Ingredient> { Ingredients.Wheat, Ingredients.Oats });

        // Iris.
        Iris.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.Uproot
        };
        Iris.Level2Moves = new List<Move>()
        {
            Moves.Roll, Moves.Uproot, Moves.SawgrassSlice
        };
        Iris.Level3Moves = new List<Move>()
        {
            Moves.Roll, Moves.Uproot, Moves.SawgrassSlice
        };
        Iris.Level4Moves = new List<Move>()
        {
            Moves.Roll, Moves.Uproot, Moves.SawgrassSlice, Moves.SuperHeal
        };
        Iris.Level5Moves = new List<Move>()
        {
            Moves.Roll, Moves.TwistingVines, Moves.SawgrassSlice, Moves.SuperHeal
        };
        Iris.SetDrops(new List<Ingredient> { Ingredients.Rice, Ingredients.Lettuce });

        // Frost.
        Frost.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap
        };
        Frost.Level2Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap, Moves.Freeze
        };
        Frost.Level3Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap, Moves.Freeze
        };
        Frost.Level4Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap, Moves.Freeze, Moves.IcicleShot
        };
        Frost.Level5Moves = new List<Move>()
        {
            Moves.Roll, Moves.Freeze, Moves.IcicleShot, Moves.Crystalize
        };
        Frost.SetDrops(new List<Ingredient> { Ingredients.IceCube, Ingredients.IceCube2 });

        // Snowflake.
        Snowflake.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap
        };
        Snowflake.Level2Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap, Moves.IcicleShot
        };
        Snowflake.Level3Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap, Moves.IcicleShot
        };
        Snowflake.Level4Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap, Moves.IcicleShot, Moves.Icebreath
        };
        Snowflake.Level5Moves = new List<Move>()
        {
            Moves.Roll, Moves.Icebreath, Moves.IcicleShot, Moves.BuildingIce
        };
        Snowflake.SetDrops(new List<Ingredient> { Ingredients.IceCube3, Ingredients.IceCube4 });

        // Winter 3.
        Winter.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.IceTackle
        };
        Winter.Level2Moves = new List<Move>()
        {
            Moves.Roll, Moves.IceTackle, Moves.Freeze
        };
        Winter.Level3Moves = new List<Move>()
        {
            Moves.Roll, Moves.IceTackle, Moves.Freeze
        };
        Winter.Level4Moves = new List<Move>()
        {
            Moves.Roll, Moves.IceTackle, Moves.Freeze, Moves.IcicleShot
        };
        Winter.Level5Moves = new List<Move>()
        {
            Moves.Roll, Moves.IceTackle, Moves.Icebreath, Moves.IcicleShot
        };
        Winter.SetDrops(new List<Ingredient> { Ingredients.IceCube5, Ingredients.IceCube2 });

        // Ice Enemy 4.
        IceEnemy4.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap
        };
        IceEnemy4.Level2Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap, Moves.Freeze
        };
        IceEnemy4.Level3Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap, Moves.Freeze
        };
        IceEnemy4.Level4Moves = new List<Move>()
        {
            Moves.Roll, Moves.FrozenTap, Moves.Freeze, Moves.BuildingIce
        };
        IceEnemy4.Level5Moves = new List<Move>()
        {
            Moves.Roll, Moves.BuildingIce, Moves.IcicleShot, Moves.Crystalize
        };
        IceEnemy4.SetDrops(new List<Ingredient> { Ingredients.IceCube3, Ingredients.IceCube });

        // Ice Enemy 5.
        IceEnemy5.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.IceTackle
        };
        IceEnemy5.Level2Moves = new List<Move>()
        {
            Moves.Roll, Moves.IceTackle, Moves.Freeze
        };
        IceEnemy5.Level3Moves = new List<Move>()
        {
            Moves.Roll, Moves.IceTackle, Moves.Freeze
        };
        IceEnemy5.Level4Moves = new List<Move>()
        {
            Moves.Roll, Moves.IceTackle, Moves.Freeze, Moves.BuildingIce
        };
        IceEnemy5.Level5Moves = new List<Move>()
        {
            Moves.Roll, Moves.BuildingIce, Moves.Icebreath, Moves.IcicleShot
        };
        IceEnemy5.SetDrops(new List<Ingredient> { Ingredients.IceCube4, Ingredients.IceCube5 });

        // Nature Boss.
        NatureBoss.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.SuperHeal, Moves.PetalStorm, Moves.SneakAttack
        };

        // Ice Boss.
        IceBoss.Level1Moves = new List<Move>()
        {
            Moves.Roll, Moves.Icebreath, Moves.Crystalize, Moves.DryIceSlam
        };
    }
}

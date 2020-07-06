using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    // Enemies.
    public static readonly Enemy Acorn = new Enemy("Acorn", 20, 20, 5f, 4f, 3f, // Name & Stats.
        new Dictionary<Type, float>() { [Types.Nature] = 1f }, // Type Affinities.
        new List<Move>() { Moves.Roll }, 1.5f); // Move list.

    public static readonly Enemy Herb = new Enemy("Herb", 20, 20, 5f, 4f, 3f,
        new Dictionary<Type, float>() { [Types.Nature] = 1f },
        new List<Move>() { Moves.Roll }, 1.5f);

    public static readonly Enemy Peanut = new Enemy("Peanut", 20, 20, 5f, 4f, 3f,
        new Dictionary<Type, float>() { [Types.Nature] = 1f },
        new List<Move>() { Moves.Roll }, 1.5f);

    public static readonly Enemy NatureEnemy4 = new Enemy("Nature Enemy 4", 20, 20, 5f, 4f, 3f,
        new Dictionary<Type, float>() { [Types.Nature] = 1f },
        new List<Move>() { Moves.Roll }, 1.5f);

    public static readonly Enemy NatureEnemy5 = new Enemy("Nature Enemy 5", 20, 20, 5f, 4f, 3f,
        new Dictionary<Type, float>() { [Types.Nature] = 1f },
        new List<Move>() { Moves.Roll }, 1.5f);

    public static readonly Enemy Frost = new Enemy("Frost", 20, 20, 4f, 5f, 3f,
        new Dictionary<Type, float>() { [Types.Ice] = 1f },
        new List<Move>() { Moves.Slam }, 1.5f);

    public static readonly Enemy Snowflake = new Enemy("Snowflake", 20, 20, 4f, 5f, 3f,
        new Dictionary<Type, float>() { [Types.Ice] = 1f },
        new List<Move>() { Moves.Slam }, 1.5f);

    public static readonly Enemy IceEnemy3 = new Enemy("Ice Enemy 3", 20, 20, 4f, 5f, 3f,
        new Dictionary<Type, float>() { [Types.Ice] = 1f },
        new List<Move>() { Moves.Slam }, 1.5f);

    public static readonly Enemy IceEnemy4 = new Enemy("Ice Enemy 4", 20, 20, 4f, 5f, 3f,
        new Dictionary<Type, float>() { [Types.Ice] = 1f },
        new List<Move>() { Moves.Slam }, 1.5f);

    public static readonly Enemy IceEnemy5 = new Enemy("Ice Enemy 5", 20, 20, 4f, 5f, 3f,
        new Dictionary<Type, float>() { [Types.Ice] = 1f },
        new List<Move>() { Moves.Slam }, 1.5f);

    // Bosses.
    public static readonly Enemy ExampleBoss = new Enemy("Nature Boss", 100, 100, 20f, 15f, 10f,
        new Dictionary<Type, float>() { [Types.Nature] = 10f },
        new List<Move>() { Moves.Slam, Moves.Roll },
        1f, 2.5f, false); // Size & CanMove.

    public static readonly Enemy ExampleBoss2 = new Enemy("Ice Boss", 100, 100, 15f, 20f, 10f,
        new Dictionary<Type, float>() { [Types.Ice] = 10f },
        new List<Move>() { Moves.Slam, Moves.Roll },
        1f, 2.5f, false);
}

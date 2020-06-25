using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Claims;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    #region Enemy Slime Declaration

    // Standard enemies.
    static readonly Enemy Acorn = new Enemy("Acorn", 0, 0, 0f, 0f, 0f, // Name & Stats.
        new Dictionary<Type, float>() { [Types.Nature] = 1f }, // Type Affinities.
        new List<Move>() { Moves.Roll } ); // Move list.

    static readonly Enemy Herb = new Enemy("Herb", 0, 0, 0f, 0f, 0f,
        new Dictionary<Type, float>() { [Types.Nature] = 1f },
        new List<Move>() { Moves.Roll, Moves.Slam });

    static readonly Enemy Peanut = new Enemy("Peanut", 0, 0, 0f, 0f, 0f,
        new Dictionary<Type, float>() { [Types.Nature] = 1f },
        new List<Move>() { Moves.Slam } );

    static readonly Enemy Frost = new Enemy("Frost", 0, 0, 0f, 0f, 0f,
        new Dictionary<Type, float>() { [Types.Ice] = 1f },
        new List<Move>() { Moves.Roll } );

    static readonly Enemy Snowflake = new Enemy("Snowflake", 0, 0, 0f, 0f, 0f,
        new Dictionary<Type, float>() { [Types.Ice] = 1f },
        new List<Move>() { Moves.Slam } );

    // Boss enemies.
    static readonly Enemy ExampleBoss = new Enemy("Example", 0, 0, 0f, 0f, 0f,
        new Dictionary<Type, float>() { [Types.Nature] = 1f, [Types.Ice] = 1f },
        new List<Move>() { Moves.Slam, Moves.Roll },
        4f, false ); // Size & CanMove.

    #endregion

    [Tooltip("Each int represents an island 1 - 6.")] public uint islandNum;

    private Dictionary<uint, List<Vector2>> spawnPoints = new Dictionary<uint, List<Vector2>>();
    private Dictionary<uint, List<Enemy>> islandEnemies = new Dictionary<uint, List<Enemy>>();

    [SerializeField] private GameObject enemySlime = null;

    private class ShuffleComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            return Random.Range(-1, 1);
        }
    }

    private void Awake()
    {
        // This part I hate.

        #region Spawn Points

        spawnPoints.Add(1, new List<Vector2> { new Vector2(0f, -15f),
                                               new Vector2(0f, 12.5f),
                                               new Vector2(20f, 0f),
                                               new Vector2(-30f, -25f),
                                               new Vector2(27.5f, -25f),
                                               new Vector2(27.5f, -47.5f) } );

        #endregion

        #region Enemies

        islandEnemies.Add(1, new List<Enemy> { Acorn, Herb, Peanut, Frost, Snowflake, ExampleBoss } );

        #endregion

        SpawnEnemies(islandNum);
    }

    private void SwitchIsland(uint newIslandNum)
    {
        islandNum = newIslandNum;

        SpawnEnemies(islandNum);
    }

    private void SpawnEnemies(uint island)
    {
        spawnPoints[island].Sort(0, spawnPoints[islandNum].Count, new ShuffleComparer<Vector2>());

        for (int i = 0; i < islandEnemies[island].Count; i++)
        {
            Enemy newEnemy = islandEnemies[island][i];
            SpawnEnemy(newEnemy, spawnPoints[island][i]);
        }
    }

    private void SpawnEnemy(Enemy enemy, Vector2 location)
    {
        GameObject newSlime = Instantiate(enemySlime, location, Quaternion.identity);

        newSlime.GetComponent<EntityData>().AssignStats(enemy);
    }
}

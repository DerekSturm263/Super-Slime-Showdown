using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    #region Enemy Slime Declaration

    // Standard enemies.
    static readonly EntityData Acorn = new EntityData("Acorn", 0, 0, 0f, 0f, 0f, // Name & Stats.
        new Dictionary<Type, float>() { [Types.Nature] = 1f }, // Type Affinities.
        new List<Move>() { Moves.Roll } ); // Move list.

    static readonly EntityData Herb = new EntityData("Herb", 0, 0, 0f, 0f, 0f,
        new Dictionary<Type, float>() { [Types.Nature] = 1f },
        new List<Move>() { Moves.Roll, Moves.Slam });

    static readonly EntityData Peanut = new EntityData("Peanut", 0, 0, 0f, 0f, 0f,
        new Dictionary<Type, float>() { [Types.Nature] = 1f },
        new List<Move>() { Moves.Slam } );

    static readonly EntityData Frost = new EntityData("Frost", 0, 0, 0f, 0f, 0f,
        new Dictionary<Type, float>() { [Types.Ice] = 1f },
        new List<Move>() { Moves.Roll } );

    static readonly EntityData Snowflake = new EntityData("Snowflake", 0, 0, 0f, 0f, 0f,
        new Dictionary<Type, float>() { [Types.Ice] = 1f },
        new List<Move>() { Moves.Slam });

    // Boss enemies.

    #endregion

    [Tooltip("Each int represents an island 1 - 6.")] public uint islandNum;

    private Dictionary<uint, List<Vector2>> spawnPoints = new Dictionary<uint, List<Vector2>>();
    private Dictionary<uint, List<EntityData>> islandEnemies = new Dictionary<uint, List<EntityData>>();

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

        spawnPoints[1].Add(new Vector2(0f, 0f));

        #endregion

        #region Enemies

        islandEnemies[1].Add(Acorn);
        islandEnemies[1].Add(Herb);
        islandEnemies[1].Add(Peanut);
        islandEnemies[1].Add(Frost);
        islandEnemies[1].Add(Snowflake);

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
            EntityData newEnemy = islandEnemies[island][i];
            SpawnEnemy(newEnemy, spawnPoints[island][i]);
        }
    }

    private void SpawnEnemy(EntityData enemy, Vector2 location)
    {
        Instantiate(enemySlime, location, Quaternion.identity);
        EntityData data = enemySlime.GetComponent<EntityData>();
        data = enemy;
    }
}

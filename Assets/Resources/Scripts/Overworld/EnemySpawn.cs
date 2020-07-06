using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [Tooltip("Each int represents an island 1 - 6.")] public uint islandNum;

    // Enemies.
    private Dictionary<Type, List<Vector2>> spawnPoints = new Dictionary<Type, List<Vector2>>(); // Dictionary represents Type as Key, List of Spawn Points as Values.
    private Dictionary<Type, List<Enemy>> islandEnemies = new Dictionary<Type, List<Enemy>>(); // Dictionary represents Type as Key, List of Enemies as Values.

    // Bosses.
    private Dictionary<uint, List<Vector2>> bossSpawnPoints = new Dictionary<uint, List<Vector2>>(); // Dictionary represents Island Number as Key, List of Spawn Points as Values.
    private Dictionary<uint, List<Enemy>> islandBosses = new Dictionary<uint, List<Enemy>>(); // Dictionary represents Island Number as Key, List of Enemies as Values.

    [SerializeField] private GameObject enemySlime = null;
    public GameObject playerSlime;

    private class ShuffleComparer<T> : IComparer<T>
    {
        public int Compare(T x, T y)
        {
            return Random.Range(-1, 1);
        }
    }

    private void Awake()
    {
        #region Spawn Points

        spawnPoints.Add(Types.Nature, new List<Vector2>
        {
            new Vector2(-33f, -24.7f),
            new Vector2(-13f, -19.8f),
            new Vector2(14.5f, -18.3f),
            new Vector2(33.3f, 2.8f),
            new Vector2(32.6f, -15.5f),
            new Vector2(16.6f, 2.1f)
        });

        spawnPoints.Add(Types.Ice, new List<Vector2>
        {
            new Vector2(-37f, 5.5f),
            new Vector2(-20.7f, 16.3f),
            new Vector2(23.7f, 24.9f),
            new Vector2(-3.1f, 17.1f),
            new Vector2(38.7f, 23.5f),
            new Vector2(8.6f, 24.7f)
        });

        bossSpawnPoints.Add(1, new List<Vector2>
        {
            new Vector2(28.8f, -31.6f),
            new Vector2(-32.5f, 17.8f)
        });

        #endregion

        #region Enemies

        // First island.
        islandEnemies.Add( Types.Nature, new List<Enemy> { Enemies.Acorn, Enemies.Herb, Enemies.Peanut, Enemies.NatureEnemy4, Enemies.NatureEnemy5 } );
        islandEnemies.Add( Types.Ice, new List<Enemy> { Enemies.Frost, Enemies.Snowflake, Enemies.IceEnemy3, Enemies.IceEnemy4, Enemies.IceEnemy5 } );
        islandBosses.Add( 1, new List<Enemy> { Enemies.ExampleBoss, Enemies.ExampleBoss2 } );

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
        List<Type> islandTypes = new List<Type>();

        switch (island)
        {
            case 1:
                islandTypes.Add(Types.Nature);
                islandTypes.Add(Types.Ice);
                break;
            case 2:
                islandTypes.Add(Types.Earth);
                islandTypes.Add(Types.Water);
                break;
            case 3:
                islandTypes.Add(Types.Wind);
                islandTypes.Add(Types.Volt);
                break;
            case 4:
                islandTypes.Add(Types.Fire);
                islandTypes.Add(Types.Toxin);
                break;
            case 5:
                islandTypes.Add(Types.Light);
                islandTypes.Add(Types.Shadow);
                break;
        }

        spawnPoints[islandTypes[0]].Sort(0, spawnPoints[islandTypes[0]].Count, new ShuffleComparer<Vector2>());
        spawnPoints[islandTypes[1]].Sort(0, spawnPoints[islandTypes[1]].Count, new ShuffleComparer<Vector2>());

        foreach (Type type in islandTypes)
        {
            for (int i = 0; i < islandEnemies[type].Count; i++)
            {
                if (Vector2.Distance(playerSlime.transform.position, spawnPoints[type][i]) < 5f)
                    i++;

                Enemy newEnemy = islandEnemies[type][i];
                SpawnEnemy(newEnemy, spawnPoints[type][i]);
            }
        }

        for (int i = 0; i < islandBosses[island].Count; i++)
        {
            Enemy newBoss = islandBosses[island][i];
            SpawnEnemy(newBoss, bossSpawnPoints[island][i]);
        }
    }

    private void SpawnEnemy(Enemy enemy, Vector2 location)
    {
        GameObject newSlime = Instantiate(enemySlime, location, Quaternion.identity);

        newSlime.GetComponent<EntityData>().AssignStats(enemy);
    }
}

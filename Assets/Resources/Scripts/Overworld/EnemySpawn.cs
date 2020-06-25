using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    #region Enemy Slime Declaration

    // Standard enemies.
    static readonly EntityData AcornSlime = new EntityData("Acorn", 0, 0, 0f, 0f, 0f, // Name & Stats.
        new Dictionary<Type, float>() { [Types.Nature] = 1f }, // Type Affinities.
        new List<Move>() { Moves.Roll } ); // Move list.

    static readonly EntityData 

    // Boss enemies.

    #endregion

    [Tooltip("Must be equal to the number of enemies that can spawn on that island.")] private List<Transform> spawnPoints = new List<Transform>();

    [Tooltip("Each int represents an island 1 - 6.")] public uint islandNum;
    private readonly Dictionary<uint, List<EntityData>> islandEnemies = new Dictionary<uint, List<EntityData>>();

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
        // Add enemies.
        islandEnemies[1].Add(AcornSlime);

        spawnPoints.Sort(0, spawnPoints.Count, new ShuffleComparer<Transform>());

        for (int i = 0; i < spawnPoints.Count; i++)
        {
            EntityData newEnemy = islandEnemies[islandNum][i];
            SpawnEnemy(newEnemy, spawnPoints[i].position);
        }
    }

    private void SpawnEnemy(EntityData enemy, Vector2 location)
    {
        Instantiate(enemySlime, location, Quaternion.identity);
        EntityData data = enemySlime.GetComponent<EntityData>();
        data = enemy;
    }
}

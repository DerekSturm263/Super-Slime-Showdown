using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    #region Enemy Slime Declaration

    // Standard enemies.
    static readonly EntityData AcornSlime = new EntityData("Acorn", 0, 0, 0f, 0f, 0f, new Dictionary<Type, float>() { [Types.Nature] = 1f }, new List<Move>() { Moves.Roll } );

    // Boss enemies.

    #endregion

    private uint slimesMax = 10;
    private uint slimesCurrent = 0;

    private Transform[] spawnPoints = null;

    public uint islandNum;
    private List<EntityData> island1Enemies = new List<EntityData>() { AcornSlime };

    [SerializeField] private GameObject enemySlime = null;

    private void Update()
    {
        if (slimesCurrent < slimesMax)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        EntityData newEnemy = null;

        switch (islandNum)
        {
            case 1:
                newEnemy = island1Enemies[Random.Range(0, island1Enemies.Count)];
                break;
            case 2:
                break;
            case 3:
                break;
            case 4:
                break;
            case 5:
                break;
            case 6:
                break;
        }

        Instantiate(enemySlime);
        EntityData enemyScript = enemySlime.GetComponent<EntityData>();
        enemyScript = newEnemy;
    }
}

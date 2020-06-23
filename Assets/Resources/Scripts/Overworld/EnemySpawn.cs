using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    #region Enemy Slime Declaration

    // Standard enemies.
    static readonly EntityData AcornSlime = new EntityData("Acorn", 0, 0, 0f, 0f, 0f, new Dictionary<Type, float>() { [Types.Nature] = 1f }, new List<Move>() { Move.Roll } );

    // Boss enemies.

    #endregion

    private uint slimesMax;
    private uint slimesCurrent;

    private List<EntityData> island1Enemies = new List<EntityData>() { AcornSlime };

    private void Update()
    {
        if (slimesCurrent < slimesMax)
        {
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : EntityMove
{
    private Vector2 movVal;

    private void Start()
    {
        InvokeRepeating("ChangeDirection", 1f);
    }

    private void Update()
    {
        EnemyMove(movVal);
    }

    private void ChangeDirection()
    {
        int randomDir = Random.Range(0, 4);

        switch (randomDir)
        {
            case 0:
                movVal.x = Random.Range(0f, 1f);
                break;
            case 1:
                movVal.x = Random.Range(0f, -1f);
                break;
            case 2:
                movVal.y = Random.Range(0f, 1f);
                break;
            case 3:
                movVal.y = Random.Range(0f, -1f);
                break;
        }
    }
}

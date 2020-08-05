using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Enemy enemyData;

    private void Awake()
    {
        Moves.Initialize();
        Abilities.Initialize();
        Types.Initialize();
        Enemies.Initialize();
        PlayerInfo.Initialize();
    }
}

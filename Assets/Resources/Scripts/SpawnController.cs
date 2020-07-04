using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject gameController;

    private void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("GameController").Length == 0)
        {
            GameObject newController = Instantiate(gameController);
            DontDestroyOnLoad(newController);
        }
    }
}

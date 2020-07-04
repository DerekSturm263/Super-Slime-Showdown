using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartBattle : MonoBehaviour
{
    private GameController gc;

    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Enemy"))
        {
            gc.enemyData = col.gameObject.GetComponent<EntityData>().data;
            gc.playerLoc = transform.position;

            StartCoroutine(LoadBattle());
        }
    }

    private IEnumerator LoadBattle()
    {
        //yield return new WaitForSeconds(1f); When we add the battle opening animation this'll be important.
        SceneManager.LoadScene("Battle");
        yield return null;
    }
}

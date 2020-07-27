using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interactions : MonoBehaviour
{
    private GameController gc;
    public OverworldUIManager ui;

    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        // Start battle.
        if (col.gameObject.CompareTag("Enemy"))
            StartCoroutine(LoadBattle(col.gameObject));

        // Open tent.
        else if (col.gameObject.CompareTag("Tent"))
            ui.OpenTent();

        // Open shop.
        else if (col.gameObject.CompareTag("Shopkeeper"))
            ui.OpenShop();

        // Open cooking pot.
        else if (col.gameObject.CompareTag("Chef"))
            ui.OpenCookingPot();

        // Open online.
        else if (col.gameObject.CompareTag("Online"))
            ui.OpenOnline();
    }

    private IEnumerator LoadBattle(GameObject enemy)
    {
        gc.enemyData = enemy.GetComponent<EntityData>().data;
        PlayerInfo.lastPlayerPos = transform.position;

        // yield return new WaitForSeconds(1f); When we add the battle opening animation this will be important.
        SceneManager.LoadScene("Battle");
        yield return null;
    }
}

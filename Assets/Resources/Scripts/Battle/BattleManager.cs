using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleManager : MonoBehaviour
{
    private GameController gc;

    [Header("Player")]
    public BattlePlayer player;
    public TMPro.TMP_Text playerName;
    public Image playerHP;
    public Image playerEnergy;

    [Header("Enemy")]
    public BattleEnemy enemy;
    public TMPro.TMP_Text enemyName;
    public Image enemyHP;
    public Image enemyEnergy;

    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        playerName.text = PlayerInfo.playerName;
        enemyName.text = gc.enemyData.Name;

        player.Render();
        enemy.Render(gc.enemyData);

        UpdateStats();
    }

    public void UpdateStats()
    {
        playerHP.fillAmount = PlayerInfo.HPCurrent / PlayerInfo.HPMax;
        playerEnergy.fillAmount = PlayerInfo.EnergyCurrent / PlayerInfo.EnergyMax;

        enemyHP.fillAmount = gc.enemyData.HPCurrent / gc.enemyData.HPMax;
        enemyEnergy.fillAmount = gc.enemyData.EnergyCurrent / gc.enemyData.EnergyMax;
    }
}

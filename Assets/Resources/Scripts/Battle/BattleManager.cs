using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem.EnhancedTouch;
using System;

public class BattleManager : MonoBehaviour
{
    public enum BattleTurn
    {
        PlayerTurn, EnemyTurn, End, ToOverworld
    }
    public static BattleTurn battleTurn = BattleTurn.PlayerTurn;

    public enum AttackPhase
    {
        Attack, Dialogue
    }
    public static AttackPhase attackPhase = AttackPhase.Attack;

    public Dictionary<uint, Action> turnEffects = new Dictionary<uint, Action>();
    public uint turnsPassed = 0;

    public bool ignoreOptions = false;

    private Controls controls;
    private GameController gc;
    public GameObject battleOptions;

    [Header("Player")]
    public static BattlePlayer player;
    public TMPro.TMP_Text playerName;
    public Image playerHP;
    public Image playerEnergy;

    [Header("Enemy")]
    public static BattleEnemy enemy;
    public TMPro.TMP_Text enemyName;
    public Image enemyHP;
    public Image enemyEnergy;

    [Header("UI")]
    public TMPro.TMP_Text textBox;
    public float timePerLetter = 0.04f;
    public bool finishedWriting = false;
    public GameObject moveList;
    public GameObject snackList;
    public Button[] moves = new Button[4];

    private void Awake()
    {
        controls = new Controls();

        TouchSimulation.Enable();

        controls.UI.Tap.performed += ctx => SkipDialogue();

        battleTurn = BattleTurn.PlayerTurn;
        attackPhase = AttackPhase.Attack;
    }

    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<BattlePlayer>();
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<BattleEnemy>();

        playerName.text = PlayerInfo.playerName;
        enemyName.text = gc.enemyData.Name;

        player.Setup();
        enemy.Setup(gc.enemyData);

        for (int i = 0; i < PlayerInfo.activeMoves.Count; i++)
        {
            SetupMove(moves[i], PlayerInfo.activeMoves[i]);
        }

        foreach (Button b in moves)
        {
            if (b.GetComponentInChildren<TMPro.TMP_Text>().text == "Empty")
                b.gameObject.SetActive(false);
        }

        UpdateStats();
        PlayerTurn();
    }

    private void SetupMove(Button moveButton, Move move)
    {
        moveButton.GetComponent<BattleButton>().assignedMove = move;
        moveButton.GetComponentInChildren<TMPro.TMP_Text>().text = move.Name;
        moveButton.GetComponent<Image>().color = move.GetColor();
    }

    private void ShowOptions()
    {
        battleOptions.SetActive(true);
    }

    private void HideOptions()
    {
        battleOptions.GetComponent<Animator>().SetBool("Exit", true);
    }

    public void OnFight()
    {
        HideOptions();
        moveList.SetActive(true);
    }

    public void OnSnacks()
    {
        HideOptions();
        snackList.SetActive(true);
    }

    public void OnFlee()
    {
        HideOptions();

        float random = UnityEngine.Random.Range(0, 2);

        if (random == 1)
        {
            Write(PlayerInfo.playerName + " is trying to flee the battle...");
            battleTurn = BattleTurn.End;
        }
        else
        {
            Write(PlayerInfo.playerName + " couldn't escape!");
            battleTurn = BattleTurn.EnemyTurn;
        }
    }

    public void OnMoveBack()
    {
        ShowOptions();
        moveList.GetComponent<Animator>().SetBool("Exit", true);
    }

    public void OnSnacksBack()
    {
        ShowOptions();
        snackList.GetComponent<Animator>().SetBool("Exit", true);
    }

    private void EnemyTurn()
    {
        enemy.Attack();
    }

    private void PlayerTurn()
    {
        textBox.transform.parent.gameObject.gameObject.GetComponent<Animator>().SetBool("Exit", true);

        // Tries to run an action every time a turn comes up.
        try
        {
            turnEffects[turnsPassed]();
        } catch { }

        // Shows the options unless told not to.
        if (!ignoreOptions) ShowOptions();
    }

    public static void SwitchTurns()
    {
        if (enemy.entityStats.HPCurrent == 0 || player.entityStats.HPCurrent == 0)
        {
            battleTurn = BattleTurn.End;
            return;
        }

        if (battleTurn == BattleTurn.PlayerTurn)
            battleTurn = BattleTurn.EnemyTurn;
        else
            battleTurn = BattleTurn.PlayerTurn;
    }

    #region Textbox

    public void Write(string text)
    {
        attackPhase = AttackPhase.Dialogue;
        StartCoroutine(WriteText(text));
    }

    private IEnumerator WriteText(string text)
    {
        battleOptions.GetComponent<Animator>().SetBool("Exit", true);
        moveList.GetComponent<Animator>().SetBool("Exit", true);

        textBox.transform.parent.gameObject.SetActive(true);

        string newText = "";

        finishedWriting = false;
        timePerLetter = 0.04f;

        for (int i = 0; i < text.Length; i++)
        {
            newText += text[i];
            textBox.text = newText;

            yield return new WaitForSeconds(timePerLetter);
        }

        finishedWriting = true;
    }

    private void ClearText()
    {
        textBox.text = "";
        attackPhase = AttackPhase.Attack;
    }

    private void SkipDialogue()
    {
        if (attackPhase == AttackPhase.Dialogue)
        {
            if (finishedWriting)
            {
                ClearText();

                switch (battleTurn)
                {
                    case BattleTurn.EnemyTurn:
                        EnemyTurn();
                        break;
                    case BattleTurn.PlayerTurn:
                        PlayerTurn();
                        break;
                    case BattleTurn.End:
                        End();
                        break;
                    default:
                        ToOverworld();
                        break;
                }
            }
            else
            {
                timePerLetter = 0.02f;
            }
        }
    }

    #endregion

    public void UpdateStats()
    {
        playerHP.fillAmount = (float) player.entityStats.HPCurrent / (float) player.entityStats.HPMax;
        playerEnergy.fillAmount = (float) player.entityStats.EnergyCurrent / (float) player.entityStats.EnergyMax;
        playerHP.color = (playerHP.fillAmount > 0.5f) ? Color.Lerp(Color.yellow, Color.green, playerHP.fillAmount) : Color.Lerp(Color.red, Color.yellow, playerHP.fillAmount);

        enemyHP.fillAmount = (float) enemy.entityStats.HPCurrent / (float) enemy.entityStats.HPMax;
        enemyEnergy.fillAmount = (float) enemy.entityStats.EnergyCurrent / (float) enemy.entityStats.EnergyMax;
        enemyHP.color = (enemyHP.fillAmount > 0.5f) ? Color.Lerp(Color.yellow, Color.green, enemyHP.fillAmount) : Color.Lerp(Color.red, Color.yellow, enemyHP.fillAmount);
    }

    public void End()
    {
        if (enemy.entityStats.HPCurrent == 0)
            Win();
        else if (player.entityStats.HPCurrent == 0)
            Lose();
        else
            Tie();
    }

    public void Win()
    {
        battleTurn = BattleTurn.ToOverworld;
        int coinBonus = (int) (player.CoinBonus * 100f);
        coinBonus = (coinBonus < 0) ? 0 : coinBonus;

        List<Ingredient> loot = new List<Ingredient>();

        for (int i = 0; i < 2; i++)
        {
            loot.Add(gc.enemyData.Drops[UnityEngine.Random.Range(0, 2)]);
        }

        if (loot[0] != loot[1])
            Write(player.Name + " has won the battle!\nYou won " + coinBonus + " gold, 1 " + loot[0].ItemName + ", and 1 " + loot[1].ItemName + "!");
        else
            Write(player.Name + " has won the battle!\nYou won " + coinBonus + " gold and 2 " + loot[0].ItemName + "!");

        gc.enemyData.TimesFought++;
        PlayerInfo.goldCount += (uint) coinBonus;
        loot.ForEach(x => PlayerInfo.inventory.Add(x));
    }

    public void Lose()
    {
        battleTurn = BattleTurn.ToOverworld;
        int coinLoss = (int) (player.CoinBonus * 50f);
        coinLoss = (coinLoss < 0) ? 0 : coinLoss;
        coinLoss = (PlayerInfo.goldCount > coinLoss) ? coinLoss : (int) PlayerInfo.goldCount;

        Write(player.Name + " has lost the battle...\nYou lost " + coinLoss + " gold...");

        player.entityStats.HPCurrent = 1;
        PlayerInfo.goldCount -= (uint) coinLoss;
    }

    public void Tie()
    {
        battleTurn = BattleTurn.ToOverworld;
        Write("and has succesfully ran away!");
    }

    public void ToOverworld()
    {
        SceneManager.LoadScene("Overworld");

        PlayerInfo.playerStats.HPCurrent = (uint) player.entityStats.HPCurrent;
        PlayerInfo.playerStats.EnergyCurrent = (uint) player.entityStats.EnergyCurrent;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}

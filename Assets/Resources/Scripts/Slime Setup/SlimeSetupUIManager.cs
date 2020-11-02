using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlimeSetupUIManager : MonoBehaviour
{
    private EventSystem eventSystem;
    private DialogueManager dm;

    public Image player;
    public TMPro.TMP_Text currentTypeName;
    
    public GameObject typeAnim;

    public Type currentType = Types.Typeless;

    public TMPro.TMP_Text[] stats;

    private TouchScreenKeyboard keyboard;

    public void Awake()
    {
        eventSystem = EventSystem.current;
        dm = FindObjectOfType<DialogueManager>();

        keyboard = new TouchScreenKeyboard("", TouchScreenKeyboardType.DecimalPad, false, false, false, false, "", 12);

        dm.WriteDialogue(AllDialogue.introduction, new System.Action(() =>
        {
            typeAnim.SetActive(true);
        }));
    }

    public void OnSelectType()
    {
        currentType = eventSystem.currentSelectedGameObject.GetComponent<ButtonType>().buttonType;

        currentTypeName.text = currentType.Name;
        player.color = currentType.TypeColor;

        stats[0].text = (currentType.statBoosts.HPMax + 19).ToString();
        stats[1].text = (currentType.statBoosts.EnergyMax + 19).ToString();
        stats[2].text = (currentType.statBoosts.Pow + 4).ToString();
        stats[3].text = (currentType.statBoosts.Def + 4).ToString();
        stats[4].text = (currentType.statBoosts.Spd + 4).ToString();
    }

    public void OnConfirmType()
    {
        if (currentType == Types.Typeless)
            return;

        typeAnim.GetComponent<Animator>().SetBool("Close", true);

        dm.WriteDialogue(AllDialogue.introduction2, new System.Action(() =>
        {
            TouchScreenKeyboard.Open("", TouchScreenKeyboardType.Default);
        }));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || keyboard.status == TouchScreenKeyboard.Status.Done)
        {
            ConfirmName();
        }
    }

    private void ConfirmName()
    {
        dm.WriteDialogue(AllDialogue.introduction3, new System.Action(() =>
        {
            PlayerInfo.playerName = keyboard.text;

            PlayerInfo.LearnMove(Moves.Roll);
            PlayerInfo.RaiseAffinity(currentType, 1f);

            PlayerInfo.hasSlime = true;
            SceneManager.LoadScene("Overworld");
        }));
    }
}

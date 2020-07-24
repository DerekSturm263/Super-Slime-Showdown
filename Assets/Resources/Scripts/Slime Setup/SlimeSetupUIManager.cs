using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class SlimeSetupUIManager : MonoBehaviour
{
    private EventSystem eventSystem;

    public SpriteRenderer playerSprtRndr;

    public TMPro.TMP_InputField nameSlot;
    public TMPro.TMP_Text typePrompt;

    public Animator nameAnim;
    public Animator typeAnim;

    public Type currentType = Types.Typeless;

    public void Awake()
    {
        eventSystem = EventSystem.current;
    }

    public void OnInputFieldEnter()
    {
        // Name needs to be at least 1 character, not counting spaces.
        if (nameSlot.text.Trim().Length == 0)
            return;

        PlayerInfo.playerName = nameSlot.text;

        nameAnim.SetBool("GoToTypes", true);
        typeAnim.SetBool("GoToTypes", true);
    }

    public void OnSelectType()
    {
        Type newType = eventSystem.currentSelectedGameObject.GetComponent<ButtonType>().buttonType;

        if (currentType != newType)
        {
            currentType = newType;
            typePrompt.text = "Choose a type for your slime.\nTap the square again to select it.\nType Selected: " + currentType.Name;

            playerSprtRndr.color = currentType.TypeColor;
        }
        else
        {
            OnConfirmType();
        }
    }

    public void OnConfirmType()
    {
        PlayerInfo.LearnMove(Moves.Roll);
        PlayerInfo.RaiseAffinity(currentType, 1f);

        typeAnim.SetBool("EndScene", true);
        StartCoroutine(LoadOverworld());
    }

    private IEnumerator LoadOverworld()
    {
        PlayerInfo.hasSlime = true;
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Overworld");
    }
}

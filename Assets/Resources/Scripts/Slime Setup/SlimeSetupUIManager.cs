using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SlimeSetupUIManager : MonoBehaviour
{
    public TMPro.TMP_InputField nameSlot;
    public Animator anim;

    public void OnInputFieldEnter()
    {
        PlayerInfo.playerName = nameSlot.text;
        anim.SetBool("EndScene", true);
        StartCoroutine(LoadOverworld());
    }

    private IEnumerator LoadOverworld()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Overworld");
    }
}

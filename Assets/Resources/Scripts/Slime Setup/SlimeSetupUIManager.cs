using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SlimeSetupUIManager : MonoBehaviour
{
    public TMPro.TMP_InputField nameSlot;

    public void OnInputFieldEnter()
    {
        PlayerInfo.playerName = nameSlot.text;
        StartCoroutine(LoadOverworld());
    }

    private IEnumerator LoadOverworld()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Overworld");
    }
}

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem.EnhancedTouch;

public class TitleUIManager : MonoBehaviour
{
    private Controls controls;
    public Animator anim;

    private void Awake()
    {
        controls = new Controls();

        TouchSimulation.Enable();

        controls.UI.Tap.performed += ctx => StartGame();
    }

    private void StartGame()
    {
        anim.SetBool("EndScene", true);

        if (PlayerInfo.hasSlime)
            StartCoroutine(LoadOverworld());
        else
            StartCoroutine(LoadSlimeSetup());
    }
    private IEnumerator LoadSlimeSetup()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Slime Setup");
    }
    private IEnumerator LoadOverworld()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Overworld");
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

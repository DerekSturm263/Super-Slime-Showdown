using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.UI;

public class TitleUIManager : MonoBehaviour
{
    private Controls controls;
    public Animator anim;
    public GameObject slimeTransition;

    private void Awake()
    {
        controls = new Controls();

        TouchSimulation.Enable();

        controls.UI.Tap.performed += ctx => StartGame();
    }

    private void StartGame()
    {
        anim.SetBool("EndScene", true);
        slimeTransition.GetComponent<Image>().material.SetFloat("Pattern", Random.Range(-1000f, 1000f));

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

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

        controls.UI.Tap.performed += ctx => StartCoroutine(StartGame());
    }

    private IEnumerator StartGame()
    {
        anim.SetBool("EndScene", true);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Overworld");
    }
}

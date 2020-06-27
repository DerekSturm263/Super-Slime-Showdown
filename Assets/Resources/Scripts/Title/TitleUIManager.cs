using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem.EnhancedTouch;

public class TitleUIManager : MonoBehaviour
{
    private Controls controls;

    private void Awake()
    {
        controls = new Controls();

        TouchSimulation.Enable();

        controls.Player.StartMovement.performed += ctx => StartGame();
    }

    private void StartGame()
    {
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

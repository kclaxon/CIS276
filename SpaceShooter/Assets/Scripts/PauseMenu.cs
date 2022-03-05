using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenuUI;

    [SerializeField] private bool isPaused;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
        }

        if(isPaused)
        {
            Time.timeScale = 0;
            ActivateMenu();
        }

        else
        {
            Time.timeScale = 1;
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        pauseMenuUI.SetActive(true);
    }

   public void DeactivateMenu()
    {
        pauseMenuUI.SetActive(false);
        isPaused = false;
    }
}

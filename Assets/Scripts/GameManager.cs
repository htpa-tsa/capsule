using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject deathPanel;
    private bool pauseGame = false;

    private void Start()
    {
        deathPanel.SetActive(false);
    }

    public void GameOver()
    {
        deathPanel.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        ToggleTime();
    }

    private void ToggleTime()
    {
        pauseGame = !pauseGame;
        if (pauseGame)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }

    public void Retry()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        ToggleTime();
        SceneManager.LoadScene("town of beginnings");
    }
}

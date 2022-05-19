using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Controller : MonoBehaviour
{
    public GameObject startScreen;
    public GameObject gameoverScreen;

    public Bird_Controller cici;

    public void StartGame()
    {
        startScreen.SetActive(false);
        cici.gamestart = true;
        Time.timeScale = 1;
    }

    public void FinishGame()
    {
        gameoverScreen.SetActive(true);
        cici.GameOverPanel.SetActive(true);
    }
}

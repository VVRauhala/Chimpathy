using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject PauseScreen;
    public boolean paused;

    // Use this for initialization
    void Start()
    {
        paused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.KeyDown("escape"))
        {
            PauseGame();
        }
    }

    // Pauses and unpauses the game
    public void PauseGame() {
        if (paused == true) {
            PauseScreen.SetActive(false);
            Time.timeScale = 1F;
        }
        else if (paused == false) {
            Time.timeScale = 0F;
            PauseScreen.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public GameObject PauseScreen;
    public PauseScreenController pauseScript;
 

    // Use this for initialization
    void Start()
    {
        PauseScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (!PauseScreen.activeInHierarchy)
            {
                PauseGame();
            }
            else if (PauseScreen.activeInHierarchy)
            {
                ContinueGame();
                pauseScript.IntroDown();
            }
        }
    }

    // Pauses game
    public void PauseGame() {
         PauseScreen.SetActive(true);
         Time.timeScale = 0F;
    }

    // Continue game
    public void ContinueGame()
    {
        PauseScreen.SetActive(false);
        Time.timeScale = 1F;
    }
}

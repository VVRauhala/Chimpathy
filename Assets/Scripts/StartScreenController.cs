using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScreenController : MonoBehaviour {

    public GameObject StartScreen;
    public Button StartButton;
    public Button QuitButton;
    public Button IntroductionButton;
    public Button IntroBackButton;
    public Text IntroductionText;

    // Use this for initialization
    void Start () {
        // Stop time while in the menu
        Time.timeScale = 0F;
        // Setting up buttons
        StartButton.GetComponent<Button>().onClick.AddListener(OnStartButtonClick);
        QuitButton.GetComponent<Button>().onClick.AddListener(OnQuitButtonClick);
        IntroductionButton.GetComponent<Button>().onClick.AddListener(IntroUp);
        IntroBackButton.GetComponent<Button>().onClick.AddListener(IntroDown);
    }

    void Update() {
        if (Input.GetKey("space")) {
            OnStartButtonClick();
        }
        /*// Quit game
        if (Input.GetKey("escape")) {
            OnQuitButtonClick();
        }*/
    }

    // Starting game
    void OnStartButtonClick() {
        // Unpause game
        Time.timeScale = 1F;
        IntroDown();
        // Hide the menu
        StartScreen.SetActive(false);
    }

    // Quit game
    void OnQuitButtonClick() {
        Application.Quit();
    }

    // Introductions
    void IntroUp() {
        StartButton.gameObject.SetActive(false);
        QuitButton.gameObject.SetActive(false);
        IntroductionButton.gameObject.SetActive(false);
        IntroductionText.gameObject.SetActive(true);
        IntroBackButton.gameObject.SetActive(true);
    }
    
    // Back to start screen from intro page
    void IntroDown() {
        IntroductionText.gameObject.SetActive(false);
        IntroBackButton.gameObject.SetActive(false);
        StartButton.gameObject.SetActive(true);
        QuitButton.gameObject.SetActive(true);
        IntroductionButton.gameObject.SetActive(true);
    }
}
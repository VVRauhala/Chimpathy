using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScreenController : MonoBehaviour {

    public GameObject PauseScreen;
    public Button ContinueButton;
    public Button QuitButton;
    public Button IntroductionButton;
    public Button IntroBackButton;
    public Text IntroductionText;

    // Use this for initialization
    void Start () {
        // Stop time while in the menu
        Time.timeScale = 0F;
        // Setting up buttons
        ContinueButton.GetComponent<Button>().onClick.AddListener(OnContinueButtonClick);
        QuitButton.GetComponent<Button>().onClick.AddListener(OnQuitButtonClick);
        IntroductionButton.GetComponent<Button>().onClick.AddListener(IntroUp);
        IntroBackButton.GetComponent<Button>().onClick.AddListener(IntroDown);
    }

    void Update() {

    }

    // Pause game
    void OnContinueButtonClick() {
        PauseScreen.SetActive(false);
        Time.timeScale = 1f;
    }

    // Quit game
    void OnQuitButtonClick() {
        Application.Quit();
    }

    // Introductions
    void IntroUp() {
        ContinueButton.gameObject.SetActive(false);
        QuitButton.gameObject.SetActive(false);
        IntroductionButton.gameObject.SetActive(false);
        IntroductionText.gameObject.SetActive(true);
        IntroBackButton.gameObject.SetActive(true);
    }
    
    // Back to start screen from intro page
    public void IntroDown() {
        IntroductionText.gameObject.SetActive(false);
        IntroBackButton.gameObject.SetActive(false);
        ContinueButton.gameObject.SetActive(true);
        QuitButton.gameObject.SetActive(true);
        IntroductionButton.gameObject.SetActive(true);
    }
}
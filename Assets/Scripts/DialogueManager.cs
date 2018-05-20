using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;
    public bool dActive;
    
    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (dActive && Input.GetKeyDown(KeyCode.K))
        {
            dBox.SetActive(false);
            dActive = false;
        }
	}

    public void ShowBox(string dialog)
    {
        dActive = true;
        dBox.SetActive(true);
        dText.text = dialog;
    }
}

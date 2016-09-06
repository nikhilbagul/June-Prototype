using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameState : MonoBehaviour {

    public int cluesFound;
    public bool devMode = false;
    public Text UIClue_text, GameOverText;
    public GameObject scene2_door;

    void Start () {
        cluesFound = 0;
	}
	
	void Update ()
    {

        UIClue_text.text = "Clues found : " + cluesFound + "/4";

        if (cluesFound == 4)
        {
            GameOverText.gameObject.SetActive(true);
        }

        if (cluesFound == 3 && !scene2_door.activeSelf)
        {
            scene2_door.SetActive(true);
        }

	    if(devMode)
        {
            
        }
	}
}

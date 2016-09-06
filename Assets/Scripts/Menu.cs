using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {

    public float secondsToWait;
    public Text loadText;
    private bool load;

    void Start()
    {
        load = false;
        StartCoroutine(WaitNSeconds(secondsToWait));
        loadText.enabled = false;
    }
	
	void Update () {
        if (load)
        {

            if (Input.GetButton("Fire1"))
            //if(Input.anyKeyDown)
            {
                Debug.Log("Fire1 detected");
                Application.LoadLevel(1);
            }
        }
	
	}

    IEnumerator WaitNSeconds(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        loadText.enabled = true;
        load = true;
    }
}

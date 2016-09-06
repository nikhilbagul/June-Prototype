using UnityEngine;
using System.Collections;

public class Flashlight_control : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.F))
        {
            GetComponent<Light>().enabled = !GetComponent<Light>().enabled;
        }
	
	}
}

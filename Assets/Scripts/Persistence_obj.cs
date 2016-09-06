using UnityEngine;
using System.Collections;

public class Persistence_obj : MonoBehaviour {

    //private static Persistence_obj instance;
    //public static Persistence_obj Instance 
    /*
    {
        get { return instance; }
    }
    */
	// Use this for initialization
	void Start ()
    {
        /*
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        */
        DontDestroyOnLoad(this.gameObject); 
	}
}

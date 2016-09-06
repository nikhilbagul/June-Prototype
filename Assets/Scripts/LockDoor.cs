using UnityEngine;
using System.Collections;
using DG.Tweening;

public class LockDoor : MonoBehaviour {

    public AudioClip doorSound;
    public AudioSource source;
  

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }



    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            source.Play();
        }        
    }

    
}
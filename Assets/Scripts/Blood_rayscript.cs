using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;

public class Blood_rayscript : MonoBehaviour
{
    public Camera FirstPersonCamera;
    public Text UIText;

    private GameState GS;
    private bool clueFound;

    Ray shootRay;                                   // A ray from the camera forwards.
    RaycastHit shootHit;                            // A raycast hit to get information about what was hit.
    int interactableMask;                           // A layer mask so the raycast only hits things on the Interactable layer.

    // Use this for initialization
    void Start ()
    {
        clueFound = false;
        Cursor.visible = false;
        GS = GameObject.Find("GameState").GetComponent<GameState>();

        // Create a layer mask for the Shootable layer.
        interactableMask = LayerMask.GetMask("Interactable");
    }
	
	// Update is called once per frame
	void Update ()
    {

        shootRay.origin = transform.position;
        shootRay.direction = transform.forward;

        Debug.DrawRay(transform.position, transform.forward*5, Color.green);     // Draws the raycast

        // Perform the raycast against gameobjects on the shootable layer and if it hits something...
        if (Physics.Raycast(shootRay, out shootHit, 2, interactableMask))
        {
            UIText.gameObject.SetActive(true);
            if (Input.GetKey(KeyCode.E))
            {
                FirstPersonCamera.DOFieldOfView(50.0f, 0.75f);
                UIText.gameObject.SetActive(false);

                if (shootHit.collider.tag == "Clue")
                {
                    GS.cluesFound++;
                    shootHit.collider.tag = "Found";                                        
                }

                if (shootHit.collider.tag == "Scene2_door")
                {
                    Application.LoadLevel(Application.loadedLevel + 1);
                }
            }

            if (Input.GetKeyUp(KeyCode.E))
            {
                FirstPersonCamera.DOFieldOfView(60.0f, 0.75f);                
            }            
        }

        else
        {
            UIText.gameObject.SetActive(false);
        }


        /*
        if (Physics.Raycast(bloodRay, out hit,2))
        {
            clueFound = false;
            if (hit.collider.tag == "Clue")
            {
                // Debug.Log("Ray hit !!!");
                UIText.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    FirstPersonCamera.DOFieldOfView(50.0f, 0.75f);
                    if(clueFound == false)
                    {
                        clueFound = true;
                        GS.cluesFound++;
                        
                    }
                }

                if(Input.GetKeyUp(KeyCode.E))
                {
                    FirstPersonCamera.DOFieldOfView(60.0f, 0.75f);
                    //Destroy(hit.transform.gameObject);
                    Clue = hit.transform.gameObject;
                    Clue.tag = "Door_L";
                }
            }
        }
        else {
            UIText.SetActive(false);
        }



        if (Physics.Raycast(bloodRay, out hit, 2))
        {
            
            if (hit.collider.tag == "NotClue")
            {
                Debug.Log("Ray hit !!!");
                UIText.SetActive(true);
                if (Input.GetKeyDown(KeyCode.E))
                {
                    FirstPersonCamera.DOFieldOfView(50.0f, 0.75f);                   
                }

                if (Input.GetKeyUp(KeyCode.E))
                {
                    FirstPersonCamera.DOFieldOfView(60.0f, 0.75f);
                    //Destroy(hit.transform.gameObject);
                    Clue = hit.transform.gameObject;
                    Clue.tag = "Door_L";
                }
            }
        }
        else
        {
            UIText.SetActive(false);
        }

    */

    }
}

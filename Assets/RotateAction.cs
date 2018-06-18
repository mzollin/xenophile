using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAction : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        // If the player has not touched the screen, we are done with this update.
        Touch touch;
        if (Input.touchCount < 1 || (touch = Input.GetTouch(0)).phase != TouchPhase.Began)
        {
            return;
        }

        Camera camera = GameObject.FindObjectOfType<Camera>();

        // Raycast against the location the player touched to search for planes.

        Ray raycast = camera.ScreenPointToRay(touch.position);
        RaycastHit raycastHit;
        if (Physics.Raycast(raycast, out raycastHit))
        {
            Debug.LogError("Something Hit");
            if (raycastHit.collider.name == name)
            {
                TaskOnClick();
            }
        }
        else
        {
            Debug.LogError("No hit detected");
        }

    }

    void TaskOnClick()
    {
        animation_rotate rot = GetComponent<animation_rotate>();
        if (rot != null)
        {
            rot.rotate = !rot.rotate;
        }
    }


}

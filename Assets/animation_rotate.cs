using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_rotate : MonoBehaviour {

    public bool rotate = true;
    public bool rotate_left = false;
    public bool rotate_up = false;
    public bool rotate_right = true;
    public bool rotate_down = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void FixedUpdate()
    {
        Transform transform = GetComponent<Transform>();
        //Vector3 k_ModelRotation = new Vector3(0.0f, 1.0f, 0.0f);
        if (rotate)
        {
            //transform.Rotate(Vector3.up * 20 * Time.deltaTime);
            if (rotate_left)
            {
                transform.Rotate(Vector3.down * 20 * Time.deltaTime);
            }
            else if (rotate_right)
            {
                transform.Rotate(Vector3.up * 20 * Time.deltaTime);
            }
        }
    }
}

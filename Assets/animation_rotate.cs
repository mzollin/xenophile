using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_rotate : MonoBehaviour {

    public bool rotate = true;
    public bool rotate_left = false;
    public bool rotate_up = false;
    public bool rotate_right = true;
    public bool rotate_down = false;
    public bool suzanne = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void FixedUpdate()
    {
        Transform transform = GetComponent<Transform>();
        if (rotate)
        {
            if (rotate_left)
            {
                if (suzanne)
                {
                    transform.Rotate(Vector3.back * 25 * Time.deltaTime);
                }
                else
                {
                    transform.Rotate(Vector3.down * 25 * Time.deltaTime);
                }
            }
            else if (rotate_right)
            {
                if (suzanne)
                {
                    transform.Rotate(Vector3.forward * 25 * Time.deltaTime);
                }
                else
                {
                    transform.Rotate(Vector3.up * 25 * Time.deltaTime);
                }
            }
        }
    }
}

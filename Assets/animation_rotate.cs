using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        Transform transform = GetComponent<Transform>();
        Vector3 k_ModelRotation = new Vector3(0.0f, 1.0f, 0.0f);
        transform.Rotate(k_ModelRotation * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_at_me : MonoBehaviour {
    public Camera FirstPersonCamera;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Transform transform = GetComponent<Transform>();
        //Vector3 k_ModelRotation = new Vector3(0.0f, 1.0f, 0.0f);
        //transform.Rotate(Vector3.up * 15 * Time.deltaTime);
        //transform.LookAt(Camera.current.transform.position);
        
        transform.LookAt(FirstPersonCamera.transform);
    }
    private void FixedUpdate()
    {
        //Camera FirstPersonCamera;
        //Transform transform = GetComponent<Transform>();
        //Vector3 k_ModelRotation = new Vector3(0.0f, 1.0f, 0.0f);
        //transform.Rotate(Vector3.up * 15 * Time.deltaTime);
        //transform.LookAt(FirstPersonCamera.transform.position);
    }
}

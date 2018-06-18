using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximitySensor : MonoBehaviour {

    public GameObject obj;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 campos = obj.GetComponent<Transform>().position;
        Vector3 pos = GetComponent<Transform>().position;
        if(Vector3.Distance(campos, pos) <= 1.5)
        {
            GetComponent<MeshRenderer>().enabled = true;
            foreach(var c in GetComponentsInChildren<MeshRenderer>()){
                c.enabled = true;
            }
        }
        else
        {
            GetComponent<MeshRenderer>().enabled = false;
            foreach (var c in GetComponentsInChildren<MeshRenderer>())
            {
                c.enabled = false;
            }
        }
	}
}

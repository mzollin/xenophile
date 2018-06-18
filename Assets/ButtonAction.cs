using GoogleARCore;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]

public class ButtonAction : MonoBehaviour {

    public GameObject obj;

    public string nextScene;

	// Use this for initialization
	void Start () {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
	}
	
	// Update is called once per frame
	void Update () {
        // If the player has not touched the screen, we are done with this update.
        Touch touch;
        if (Input.touchCount < 1 || (touch = Input.GetTouch(0)).phase != TouchPhase.Began)
        {
            return;
        }

        // Raycast against the location the player touched to search for planes.
        TrackableHit hit;
        TrackableHitFlags raycastFilter = TrackableHitFlags.None;

        if (Frame.Raycast(touch.position.x, touch.position.y, raycastFilter, out hit))
        {

            if((hit.Trackable.Equals(this)))
            {
                TaskOnClick();
            }
        }

    void TaskOnClick()
    {
        Debug.Log("Button " + gameObject.name + " clicked.");
        StringHolder.name = obj.name;
        SceneManager.LoadScene(nextScene);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallowmouse : MonoBehaviour {
    [SerializeField] GameObject gun;
    [SerializeField] Camera playerCamera;
    [SerializeField] GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Mouse X") != 0)
        {
            playerCamera.transform.Rotate(0, Input.GetAxis("Mouse X") * 50, 0);
        }
        if(Input.GetAxis("Mouse X") != 0)
        {
            playerCamera.transform.Rotate(-Input.GetAxis("Mouse X") * 2, 0, 0);
        }
	}
}

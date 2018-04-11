using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) )
		{
			Debug.Log("space pressed");
		}
		if (Input.GetKeyDown(KeyCode.H)) 
		{
			Debug.Log("H pressed");
		}
	}
}

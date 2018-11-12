using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {
//Place on 3D GameObject and change Camera to Perspective/Orthographic.

	public Vector3 tempPos;
	//Temporary position for setting the Vector3.
	
	private void Update()
	{
		tempPos = Input.mousePosition;
		tempPos.z = 0;
		//Sets the location of object based on set transform location.
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		print(Camera.main.ScreenToWorldPoint(Input.mousePosition));
	}
}

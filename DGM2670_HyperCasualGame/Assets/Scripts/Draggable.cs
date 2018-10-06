using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draggable : MonoBehaviour
{

	private Vector3 currentPosition;
	private Vector3 newPosition;
	private Camera cam;
	
	
	void Start ()
	{
		//This will ensure the camera is set up when the scene begins.
		cam = Camera.main;
	}

	private void OnMouseDown()
	{
		currentPosition = transform.position - cam.ScreenToWorldPoint(Input.mousePosition);
	}

	void OnMouseDrag()
	{
		newPosition = currentPosition + cam.ScreenToWorldPoint(Input.mousePosition);
		newPosition.z = 0;
		transform.position = newPosition;
		//ScreentoWorld takes wherever the edge of the screen is in camera and puts into worldspace.
	}
}

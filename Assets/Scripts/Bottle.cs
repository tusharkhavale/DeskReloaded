using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bottle : MonoBehaviour {
	
	void OnMouseDown()
	{
		MainController.controller.OnClickMarker(Marker.Bottle);
	}
}

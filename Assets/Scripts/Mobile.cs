using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobile : MonoBehaviour {

	void OnMouseDown()
	{
		MainController.controller.OnClickMarker(Marker.Mobile);
	}
}

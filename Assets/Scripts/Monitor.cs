using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monitor : MonoBehaviour {

	void OnMouseDown()
	{
		MainController.controller.OnClickMarker(Marker.Monitor);
	}
}

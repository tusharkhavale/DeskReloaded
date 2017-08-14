using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : MonoBehaviour {

	void OnMouseDown()
	{
		MainController.controller.OnClickMarker(Marker.Charger);
	}
}

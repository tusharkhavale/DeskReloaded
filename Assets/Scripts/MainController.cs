using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainController : MonoBehaviour {

	public static MainController controller;
	public GameObject frame;
	public Button btnCancel;
	public Button btnBuy;

	void Awake()
	{
		controller = this;
	}

	void Start()
	{
		btnCancel.onClick.AddListener (this.OnClickCancel);
		btnBuy.onClick.AddListener (this.OnClickBuy);
	}

	public void OnClickMarker(Marker marker)
	{
		frame.gameObject.SetActive (true);
		switch (marker) 
		{
			case Marker.Bag:
				break;

			case Marker.Bottle:
				break;

			case Marker.Charger:
				break;

			case Marker.Mobile:
				break;

			case Marker.Monitor:
				break;
		}

	}

	public void OnClickBuy()
	{
		
	}

	public void OnClickCancel()
	{
		frame.SetActive (false);
	}
}

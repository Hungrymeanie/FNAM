using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public bool buttonColor = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0))
		{
	if (Physics.Raycast (Camera.main.ScreenPointToRay(Input.mousePosition))){
				buttonColor = !buttonColor;
			}
			    }

		if (buttonColor == false) {
			renderer.material.SetColor ("_Color", Color.red);
			}
	    else {
			renderer.material.SetColor ("_Color", Color.green);
		}


	}
}

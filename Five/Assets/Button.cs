using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public bool buttonColor = false;
	public Material Open;
	public Material Close;
	public DoorMovement Door;
	public Power usage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		if(Input.GetMouseButtonDown(0))
		{
	if (Physics.Raycast (Camera.main.ScreenPointToRay(Input.mousePosition), out hit)){
				if(hit.collider.gameObject == gameObject){
					buttonColor = !buttonColor;
					if (buttonColor == true) {
						usage.ChangeUsage (1);
					}else{
						usage.ChangeUsage (-1);
					}
				}
			}
			    }

		if (buttonColor == false) {
			renderer.material = Open;
			Door.openOrClosed = false;
			}
	    else {
			renderer.material = Close;
			Door.openOrClosed = true;
		}

	}
}

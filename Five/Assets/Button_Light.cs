using UnityEngine;
using System.Collections;

public class Button_Light : MonoBehaviour {
	public bool buttonColor = false;
	public Material Lightoff;
	public Material Lighton;
	public Light light;
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
			renderer.material = Lighton;
			light.enabled = false;
			}
	    else {
			renderer.material = Lightoff;
			light.enabled = true;
		}


	}
}

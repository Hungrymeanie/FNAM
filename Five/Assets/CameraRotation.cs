using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour {
	public Vector3 startRotation;
	public Vector3 endRotation;
	public float timer = 0;
	public bool whichWay = false;
	public float rotationSpeed = 0.5f;
	public bool pause = false;
	public float timer2 = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if (rotationSpeed * timer > 1) {
						timer = 0;
						whichWay = !whichWay;
			pause = true;
		} if (timer2 > 3) {
			timer2 = 0;
			pause = false;
		}
				if (pause == false) {
				
		
						if (whichWay == true) { 
								transform.rotation = Quaternion.Lerp (Quaternion.Euler (startRotation), Quaternion.Euler (endRotation), timer * rotationSpeed);
						} else {
								transform.rotation = Quaternion.Lerp (Quaternion.Euler (endRotation), Quaternion.Euler (startRotation), timer * rotationSpeed);
						}
						timer += Time.deltaTime;
				} else {
			      timer2 += Time.deltaTime;
		     }
		}
}

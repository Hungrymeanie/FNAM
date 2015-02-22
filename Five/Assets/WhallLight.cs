using UnityEngine;
using System.Collections;

public class WhallLight : MonoBehaviour {
	public bool on;
	public float timer;
	private Light WestHallLight;
	// Use this for initialization
	void Start () {
		on = true;
		timer = 0;
		WestHallLight = GetComponent<Light> (); 
	}
	
	// Update is called once per frame
	void Update () {
	timer += Time.deltaTime;
		if (timer >= 1) {
			on = !on;
			timer = 0;
		}
		if (on == true) {
			WestHallLight.enabled = true;
		}
		else {
			WestHallLight.enabled = false;
			}
	}
}

using UnityEngine;
using System.Collections;

public class Toggle_Monitor : MonoBehaviour {
	public bool toggleMonitor = false;
	public bool previous = false;
	public GameObject Monitor; 
	// Use this for initialization
	void Start () {
		Monitor.SetActive (false);
	}
	public void toggle () {
		toggleMonitor = !toggleMonitor;
	}
	// Update is called once per frame
	void Update () {
		if (toggleMonitor != previous) {
			if (toggleMonitor == true) {
				Monitor.SetActive (true);
			}else{
				Monitor.SetActive (false);
			}
		}
previous = toggleMonitor;
	}
}

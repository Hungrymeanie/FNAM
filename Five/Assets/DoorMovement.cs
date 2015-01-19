using UnityEngine;
using System.Collections;

public class DoorMovement : MonoBehaviour {
	public Vector3 downPosition;
	public Vector3 upPosition;
	// Use this for initialization
	void Start () {
		downPosition = transform.position;
		upPosition = downPosition + new Vector3 (0, 4.5f);
		transform.position = upPosition;
	}
	
	// Update is called once per frame
	void Update () {
	 
	}
}

using UnityEngine;
using System.Collections;

public class DoorMovement : MonoBehaviour {
	public Vector3 downPosition;
	public Vector3 upPosition;
	public bool openOrClosed = false;
	bool closedOrOpen = false;
	public float timer = 0.0f;
	public float doorSpeed = 2f;
	public AudioSource DoorSound;
	// Use this for initialization
	void Start () {
		downPosition = transform.position;
		upPosition = downPosition + new Vector3 (0, 4.5f);
		transform.position = upPosition;
	}
	
	// Update is called once per frame
	void Update () {
		if (openOrClosed != closedOrOpen) {
						timer = 0f;
			DoorSound.PlayOneShot(DoorSound.clip);
						closedOrOpen = openOrClosed;
				} else {
			if (openOrClosed == true) {
				transform.position = Vector3.Lerp (upPosition, downPosition, timer * doorSpeed);
			} else {
				transform.position = Vector3.Lerp (downPosition, upPosition, timer * doorSpeed);
			}

				}
		timer += Time.deltaTime;
		}
}

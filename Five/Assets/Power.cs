using UnityEngine;
using System.Collections;

public class Power : MonoBehaviour {
	public float value = 100f;
	private int usage = 1;
	public int maxUsage = 4;
	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		value -= usage * Time.deltaTime * speed;
		if (usage > maxUsage)
			usage = maxUsage;
		if (usage < 1)
			usage = 1;
	}

	public void ChangeUsage(int inc)
	{
		usage += inc;
	}

	void OnGUI()
	{
		GUILayout.BeginArea (new Rect(0, 0, Screen.width, Screen.height));
		GUILayout.BeginVertical ();
		GUILayout.BeginHorizontal ();
		GUILayout.Label ("Power: " + (int)value + "%");
		GUILayout.FlexibleSpace ();
		GUILayout.Label ("Usage: " + usage);
		GUILayout.EndHorizontal ();
		GUILayout.FlexibleSpace ();
		GUILayout.EndVertical ();
		GUILayout.EndArea ();
	}
}

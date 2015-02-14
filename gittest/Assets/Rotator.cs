using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {
	public float rate_per_second=1f;
	public float angle_per_rate=30f;
	float start_time = 0;
	// Use this for initialization
	void Start () {
		start_time = Time.time;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(Time.time>start_time+rate_per_second)
		{
			transform.Rotate(Vector3.up,angle_per_rate);
			start_time = Time.time;
		}
	}
}

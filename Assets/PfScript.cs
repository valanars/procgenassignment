using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PfScript : MonoBehaviour {

	private float counter = 0;

	public Transform floorPrefab;

	public Transform pathmakerPrefab;
	
	// Use this for initialization
	void Start ()
	{
		int pathCounter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (counter < 50)
		{
			counter = Random.Range(0.0f, 1.0f);
			if (counter <= 0.50f)
			{
				transform.Rotate(0f, 90f, 0f);
			} else if (counter > 0.25f && counter <= 0.90f)
			{
				transform.Rotate(0f, -90f, 0f);
			} else if (counter >= 0.99f)
			{
				Instantiate(pathmakerPrefab, transform.position, transform.rotation);
			}
			transform.Translate(0, 0, 5);
			Instantiate(floorPrefab, transform.position, transform.rotation);
			counter++;
		} else if (counter >= 50)
		{
			Destroy(gameObject);
		}
	}
}

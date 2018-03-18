using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PfScript : MonoBehaviour {

	private float counter = 0;

	public Transform floorPrefab;

	public Transform pathmakerPrefab;

	public float speed = 5f;

	public int pathCounter = 0;

	public static int globalTileCount = 0;
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update () {

		if (pathCounter <= 7 && counter < 50)
		{
			{
				counter = Random.Range(0.0f, 1.0f); //start mcfuckin going
				if (counter <= 0.50f)
				{
					transform.Rotate(0f, 90f, 0f);
				} else if (counter > 0.25f && counter <= 0.90f)
				{
					transform.Rotate(0f, -90f, 0f);
				} else if (counter >= 0.99f) //VERY SMALL chance to spawn a pathmaker
				{
					Instantiate(pathmakerPrefab, transform.position, transform.rotation);
					pathCounter++;
				}
				
				//move pathmaker, destroy it after a short-ish time
				transform.Translate(0f, 0f, speed);
				Instantiate(floorPrefab, transform.position, transform.rotation);
				counter++;
				globalTileCount++;
				if (counter >= 25)
				{
					Destroy(gameObject);
				}
			}
		} else if (pathCounter > 7)
		{
			return;
		}
		
			

	}
}

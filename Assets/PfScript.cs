﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PfScript : MonoBehaviour {

	private float counter = 0;

	public Transform floorPrefab;

	public Transform pathmakerSpherePF;

	private List<Transform> allPMs = new List<Transform>();
	
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
			if (counter <= 0.25f)
			{
				transform.Rotate(0f, 90f, 0f);
			} else if (counter > 0.25f && counter <= 0.50f)
			{
				transform.Rotate(0f, -90f, 0f);
			} else if (counter <= 0.99f)
			{
				Transform newPmClone = (Transform) Instantiate(pathmakerSpherePF, Random.insideUnitSphere, Random.rotation);
			}
			Instantiate(floorPrefab);
			//move...pf...5 units forward
			counter++;
		}
		else
		{
			Destroy(this.gameObject);
		}
	}
}

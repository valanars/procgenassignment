using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class PfScript : MonoBehaviour {

	private float counter = 0;

	private float maxTiles;

	private float range = 0;

	public Transform pathmakerPrefab;

	public float speed;

	public static int globalTileCount = 0;

	public Transform[] tiles;
	
	// Use this for initialization
	void Start ()
	{
		maxTiles = Random.Range(1, 100);
		speed = Random.Range(1, 4);
	}
	
	// Update is called once per frame
	void Update () {

		if (globalTileCount < 1000 && counter < 50)
		{
			range = Random.Range(0.0f, 1.0f); //start mcfuckin going
			if (range <= 0.10f)
			{
				transform.Rotate(0f, 90f, 0f);
			} else if (range <= 0.20f)
			{
				transform.Rotate(0f, -90f, 0f);
			} else if (range <= .25f) //VERY SMALL chance to spawn a pathmaker
			{
				Instantiate(pathmakerPrefab, transform.position, transform.rotation);
			}
			//move pathmaker, destroy it after a short-ish time
			transform.Translate(0f, 0f, speed);
			Instantiate(tiles[Random.Range(0,3)], transform.position, transform.rotation);
			counter++;
			globalTileCount++;
			if (counter == maxTiles)
			{
				Instantiate(pathmakerPrefab, transform.position, transform.rotation);
			}
		} else
		{
			Destroy(gameObject);
		}
	}
}

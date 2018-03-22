using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ReloadScript : MonoBehaviour {
	public Button reloadbutton;
	// Use this for initialization
	void Start () {

		Button btn = reloadbutton.GetComponent<Button> ();
		btn.onClick.AddListener(TaskOnClick);

		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.R))
		{
			PfScript.globalTileCount = 0;
			SceneManager.LoadScene("Scene1");
		}
	}

	void TaskOnClick (){
		PfScript.globalTileCount = 0;
		SceneManager.LoadScene("Scene1");
	
	}
}

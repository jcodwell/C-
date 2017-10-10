
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour {


	public Button play;
	//public Button exit;

	// Use this for initialization
	void Start () {

		 
		play = play.GetComponent<Button> ();

	
	}

	public void ExitPress(){


		play.enabled = false;
		//exit.enabled = false;
	}

	public void StartLevel(){
		SceneManager.LoadScene ("First");
	}


}

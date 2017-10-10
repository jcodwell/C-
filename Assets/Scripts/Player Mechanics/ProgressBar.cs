using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour {

	public int currentProgress;
	public float maxLevelProg{get; set; }
	public float CurrentLevelProg{get; set;}

	public Slider progBar;

	// Use this for initialization
	void Start () {


		maxLevelProg = 100f;
		CurrentLevelProg = 0f;
		currentProgress = 0;
		progBar.value = caluclateProgress();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.F)) {
			Debug.Log("Working");
			updateProgress (20);
			updateProgres (20);
		}


		if (Input.GetKeyDown(KeyCode.A)) {
			Debug.Log("Working");
			updateProgress (-20);
			updateProgres (-20);
		}

		//Debug.Log ("The Current Level " + CurrentLevelProg + " The Progress Bar is " + progBar.value);
		progBar.value = caluclateProgress();

	}

	void updateProgress(float progress){

		CurrentLevelProg += progress; 
	
	
	}


	void updateProgres(int progress){

 
		currentProgress += progress;

	}

	public void collectedTriangle() {
	
		updateProgress(20);
		updateProgres(20);
	
	}

	public float caluclateProgress(){

		return CurrentLevelProg/maxLevelProg;


	}



}

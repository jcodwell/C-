using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;      

public class HealthBar : MonoBehaviour {


		public float maxLevelHealth{get; set; }
		public float CurrentLevelHealth{get; set;}

		public Slider healthBar;

		// Use this for initialization
		void Start () {


			maxLevelHealth = 100f;
			CurrentLevelHealth = 0f;

			healthBar.value = caluclateHealth();
		}

		// Update is called once per frame
		void Update () {
		if (Input.GetKeyDown(KeyCode.X)) {
				Debug.Log("Working");
				updatehealth (10);
			}

			//Debug.Log ("The Current Level " + CurrentLevelProg + " The Progress Bar is " + progBar.value);
			healthBar.value = caluclateHealth();

		}

		void updatehealth(float health){

		CurrentLevelHealth += health; 


		}

		public void EnemyCollides() {

			updatehealth (10);
		}

		float caluclateHealth(){

			return CurrentLevelHealth/maxLevelHealth;


		}


	void DeathScene(){
	
		SceneManager.LoadScene ("End");

	}
	
	}

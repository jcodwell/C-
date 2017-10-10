using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectManager : MonoBehaviour {

	public GameObject obj;
	public ProgressBar progBar;       
	public GameObject enemy;                // The enemy prefab to be spawned.
	public float spawnTime = 3f;            // How long between each spawn.
	public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn fro

	void Start ()
	{
		// Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void update(){

		if(progBar.currentProgress <= 70){
			CancelInvoke("Spawn");
		}

	
	}


	void Spawn ()
	{
		// If the player has no health left...
		if(progBar.currentProgress <= 70)
		{
			// ... exit the function.
			return;
		}

		// Find a random index between zero and one less than the number of spawn points.
		int spawnPointIndex = Random.Range (0, spawnPoints.Length);

		// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
		Instantiate (enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);




	
	}

	public void OnTriggerEnter2D(Collider2D obj) {
		//Destroy (gameObject, 2f);	
		FindObjectOfType<HealthBar> ().EnemyCollides();



	}


}

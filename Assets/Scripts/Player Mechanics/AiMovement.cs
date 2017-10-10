using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

[RequireComponent (typeof (Rigidbody2D))] 
[RequireComponent(typeof(Seeker))]


public class AiMovement : MonoBehaviour {
	public Transform target;

	// How many times a seccond
	public float updateRate = 2f; 

	private Seeker seeker;

	private Rigidbody2D rb;


	//The calculated Path
	public Path path;

	//Ai speed per second
	public float speed = 300f;
	public ForceMode2D fMode;

	[HideInInspector]
	public bool pathIsEnded = false;

	// the max distance to next way point
	public float nextWaypoingDistance = 3;

	// The waypoint we are moving towards
	private int currentWaypoint = 0;


	void Start () {
		
		seeker = GetComponent<Seeker> ();
		rb = GetComponent<Rigidbody2D> ();

		if (target == null) {
			
		
		}
		// Start a new Path to the targets position and return the result of the onPath complete
		seeker.StartPath(transform.position, target.position, onPathComplete);
	
		// Prevents the path from being updated every frame
		StartCoroutine (UpdatePath ());
	
	}

	IEnumerator UpdatePath () {
	
		if (target == null) {
		//TODO: Insert a Player Search here.


		}

		seeker.StartPath(transform.position, target.position, onPathComplete);

		yield return new WaitForSeconds (1f / updateRate);

		StartCoroutine (UpdatePath ());
	}

	public void onPathComplete(Path p) {
	


		if(!p.error) {
			path = p;
			currentWaypoint = 0;

		}
	
	}

	void FixedUpdate() {
		if (target == null) {
			//TODO: Insert a Player Search here.
			return;

		}
		//TODO: Always look at player?

		if (path == null)
			return; 

		if (currentWaypoint >= path.vectorPath.Count) {
			if (pathIsEnded)
				return;

			Debug.Log("End of Path");
			pathIsEnded = true;
			return;
		
		}
		pathIsEnded = false;

		// Direction to the next waypoint
		Vector3 dir = (path.vectorPath[currentWaypoint] - transform.position).normalized;
		dir *= speed * Time.fixedDeltaTime;

		//Moving ai

		rb.AddForce (dir, fMode);

		float dist = Vector3.Distance (transform.position, path.vectorPath [currentWaypoint]);
		if (dist < nextWaypoingDistance) {
			currentWaypoint++;
			return;
		}
	}
}

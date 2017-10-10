using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleEvent : MonoBehaviour {


	public Animator triangleAnimator;

	public GameObject obj;

	void start(){
		
		
	}


	void update(){
		
	}
		

	public void OpenTriangle(GameObject obj){
		triangleAnimator.SetBool ("IsOpen", true);
	
	}


	public void OnTriggerEnter2D(Collider2D obj) {
		//Destroy (gameObject, 2f);	
		FindObjectOfType<TriangleManager> ().collectTriangle();



	}
		
	public void Delete() {
		//Destroy (gameObject, 2f);	
		Destroy (gameObject);	


	}


}

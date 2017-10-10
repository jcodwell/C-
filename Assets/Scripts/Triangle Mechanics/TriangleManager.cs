using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleManager : MonoBehaviour {

	//public Animator triangleAnimator;

	void start(){
		

	}


	/*public void OpenTriangle(){
		triangleAnimator.SetBool ("IsOpen", true);

	}*/

	public void foundTriangle()

	{

		//triangleAnimator.SetBool ("IsOpen", true);
		FindObjectOfType<ProgressBar> ().collectedTriangle();

	}



	public void collectTriangle()
	{
		FindObjectOfType<ProgressBar> ().collectedTriangle();
		FindObjectOfType<DialogueTrigger>().TriggerDialogue();
		FindObjectOfType<TriangleEvent>().Delete();


	}
	void update(){
		

	}

}
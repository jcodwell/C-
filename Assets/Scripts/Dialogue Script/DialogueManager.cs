using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class DialogueManager : MonoBehaviour {

	public Text triangleText;
	public Text dialogueText;

	public Animator animator;

	public Queue<string> sentences;



	// Use this for initialization

	void Start () {
		sentences = new Queue<string> ();
		
	}


	public void StartDialogue(Dialogue dialogue)
		
		{

		animator.SetBool ("IsOpen", true);
		
		triangleText.text = dialogue.triangle;
		
		sentences.Clear ();
		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence ();

		}

	public void DisplayNextSentence ()
		{
		if (sentences.Count == 0) {

			EndDialogue();
			return;
		}
		string sentence = sentences.Dequeue();
		dialogueText.text = sentence;
		}


	void EndDialogue()
		{
		animator.SetBool ("IsOpen", false);


	}


}

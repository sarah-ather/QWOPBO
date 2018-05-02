using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {
	public Text nameText;
	public Text dialogueText;

	public Animator animator;

	private Queue<string> sentences;
	// Use this for initialization
	void Start () {
		sentences = new Queue<string>();
	}

	public void StartDialogue(Dialogue dialogue){
		animator.SetBool ("isOpen", true);
        nameText.text = dialogue.name;
		sentences.Clear();


		foreach (string s in dialogue.sentences) {
			sentences.Enqueue (s);
		}

		DisplayNextSentence ();
	}

	public void DisplayNextSentence(){
		if (sentences.Count == 0) {
			EndDialogue ();
			return;
		}

		string sentence = sentences.Dequeue ();
		StopAllCoroutines();
		StartCoroutine (TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence){
		dialogueText.text = "";
		foreach (char c in sentence.ToCharArray()){
			dialogueText.text += c;
			yield return null;
		}
	}


	void EndDialogue(){
		animator.SetBool ("isOpen", false);
    }
}

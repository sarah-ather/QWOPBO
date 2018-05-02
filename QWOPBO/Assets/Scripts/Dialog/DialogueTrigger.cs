using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {
	public Dialogue dialogue;

    private void OnTriggerEnter(Collider collision)
    {
        TriggerDialogue();
    }

    public void TriggerDialogue(){
		FindObjectOfType<DialogueManager> ().StartDialogue(dialogue);
	}
}

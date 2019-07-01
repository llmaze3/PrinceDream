using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    private Queue<string> sentences; 
    // Start is called before the first frame update
    void Start(){
        sentences = new Queue<string>();
    }

    public void StartDialogue (Dialogue dialogue){
        //Debug.Log("Starting conversation with " + dialogue.name);
        nameText.text = dialogue.name;

        //clear existing sentences
        sentences.Clear();
        foreach(string sentence in dialogue.sentences){
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void DisplayNextSentence(){
        //if 0 we reached the end of the queue. 
        if(sentences.Count == 0){
            EndDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue(){
        Debug.Log("End of Conversation.");
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public GameObject canvas;
    public GameObject textField;
    public GameObject introDialogue;

    public string[] dialogueQuotes;
    public float[] dialogueTime;

    public AudioClip[] dialogueAudios;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunDialogue()
    {
        canvas.SetActive(true);



/*        for(int i = 0; i < introDialogue.Phrases.Count; i++)
        {
 /*           if (introDialogue.Phrases[i].Diction)
            {
                audioSource.clip = Phrases[currentPhraseIndex].Diction;
                audioSource.Play();
            }

            textField.text = introDialogue.Phrases[i].Text;
        }
        */
    }
}

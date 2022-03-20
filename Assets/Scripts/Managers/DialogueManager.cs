using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public GameObject canvas;
    public TextMeshProUGUI textField;
    public AudioSource audioSource;
    public Dialog introDialogue;

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

        foreach(Phrase phrase in introDialogue.GetPhrases())
        {
            Debug.Log(phrase);
        }

/*        foreach (DialogItem dialogue in dialogues)
        {
            ExecuteDialogue(dialogue);
        }*/
    }

/*    IEnumerator ExecuteDialogue(DialogItem dialogue)
    {
/*        textField.text = dialogue.phrase;
        if(dialogue.audio)
        {
            audioSource.clip = dialogue.audio;
            audioSource.Play();
        }
        yield return new WaitForSeconds(dialogue.time);
    }
    */

}

struct DialogItem {
    public string phrase;
    public float time;
    public AudioClip audio;
}

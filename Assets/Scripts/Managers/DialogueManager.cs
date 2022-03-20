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
        GameManager.Instance.menuManager.HideAllMenuParts();
        foreach(Phrase phrase in introDialogue.GetPhrases())
        {
            StartCoroutine(nameof(ExecuteDialogue),phrase);
        }
    }

    IEnumerator ExecuteDialogue(Phrase phrase)
    {
        textField.text = phrase.Text;
        if(phrase.Diction)
        {
            audioSource.clip = phrase.Diction;
            audioSource.Play();
        }
        yield return new WaitForSeconds(phrase.Time);
    }
}

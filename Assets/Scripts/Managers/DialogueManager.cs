using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public GameObject canvas;
    public TextMeshProUGUI textField;
    public AudioSource audioSource;
    public Dialog introDialogue;

    private int introDialogueLength;

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
        //GameManager.Instance.menuManager.HideAllMenuParts();

        introDialogueLength = introDialogue.GetPhrases().Count;
        
        //This will call one phrase at a time, with respective waiting time
        StartCoroutine(nameof(ExecuteDialogue),0);
    }

    IEnumerator ExecuteDialogue(int index)
    {
        if(index < introDialogueLength)
        { 
            Phrase phrase = introDialogue.GetPhrase(index);

            textField.text = phrase.Text;
            if(phrase.Diction)
            {
                audioSource.clip = phrase.Diction;
                audioSource.Play();
            }

            yield return new WaitForSeconds(phrase.Time);

            StartCoroutine(nameof(ExecuteDialogue),index+1);
        }
        else
        {
            //canvas.SetActive(false);
            SceneManager.LoadScene("GameScene");
        }
    }
}

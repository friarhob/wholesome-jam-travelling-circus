using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class DialogsManager : MonoBehaviour
{

    public event UnityAction OnDialogStarted;
    public event UnityAction OnDialogFinished;

    public Dialog currentDialog { get; private set; }
    List<Phrase> Phrases = new List<Phrase>();
    int currentPhraseIndex;

    [SerializeField]
    AudioSource Dictor;
    [SerializeField]
    TextMeshProUGUI PhraseText;
    [SerializeField]
    Canvas canvas;


    void Start()
    {
        
    }

    public void StartDialog(Dialog dialog)
    {

        canvas.gameObject.SetActive(true);
        currentPhraseIndex = 0;
        currentDialog = dialog;
        Phrases = currentDialog.GetPhrases();
        Debug.Log("Dialog starts!");
        OnDialogStarted?.Invoke();
        StartCoroutine("PlayPhrase", currentPhraseIndex);
    }

    public void FinishDialog()
    {
        canvas.gameObject.SetActive(false);
        Debug.Log("Dialog finished!");
        OnDialogFinished?.Invoke();
    }
  

    IEnumerator PlayPhrase(int phraseNumber)
    {

        if (phraseNumber < Phrases.Count)
        {
            if (Phrases[currentPhraseIndex].Diction)
            {
                Dictor.clip = Phrases[currentPhraseIndex].Diction;
                Dictor.Play();
            }

            PhraseText.text = Phrases[currentPhraseIndex].Text;
            yield return new WaitForSeconds(Phrases[currentPhraseIndex].Time);
            currentPhraseIndex++;
            StartCoroutine("PlayPhrase", currentPhraseIndex);
        }
        else
        {
            
            FinishDialog();
        }


    }

}

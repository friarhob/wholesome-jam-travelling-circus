using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Dialog", menuName = "DialongSystem")]
public class Dialog : ScriptableObject
{


    [SerializeField]
    List<Phrase> Phrases = new List<Phrase>();
  

    public List<Phrase> GetPhrases()
    {
        return Phrases;
    }

    public Phrase GetPhrase(int index)
    {
        return Phrases[index];
    }

    public float GetSumDialogueTime()
    {
        float time = 0;
        foreach (Phrase p in Phrases)
            time += p.Time;

        return time;
    }
}


[System.Serializable]
public struct Phrase
{
    public string Text;
    public float Time;
    public AudioClip Diction;
}

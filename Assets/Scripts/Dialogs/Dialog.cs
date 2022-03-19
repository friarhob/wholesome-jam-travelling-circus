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
}


[System.Serializable]
public struct Phrase
{
    public string Text;
    public float Time;
    public AudioClip Diction;
}

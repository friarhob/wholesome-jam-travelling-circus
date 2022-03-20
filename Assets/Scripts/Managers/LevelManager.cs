using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public event UnityAction OnStartLevel;
    public event UnityAction OnFinishLevel;

    private bool levelRunning;
    private int level;
    public float remainingTime;

    public Dialog dialogue;

    public GameObject backgroundDay;
    public GameObject foregroundDay;
    public GameObject backgroundNight;
    public GameObject foregroundNight;

    void Start()
    {
        Manager.Instance.currentLevel = this;
        levelRunning = false;
        level = 0;
        RunDialogue();
    }

    void Update()
    {
        if(levelRunning)
        {
            remainingTime -= Time.deltaTime;
            if(remainingTime < 0)
            {
                levelRunning = false;
                remainingTime = 0;

                backgroundDay.SetActive(false);
                foregroundDay.SetActive(false);
                backgroundNight.SetActive(true);
                foregroundNight.SetActive(true);
            }
        }
    }

    void RunDialogue()
    {
        if(dialogue)
        {
            
        }
    }

    private void StartLevelLogic()
    {
        levelRunning = true;
        remainingTime = 10f - level;

        backgroundDay.SetActive(true);
        foregroundDay.SetActive(true);
        backgroundNight.SetActive(false);
        foregroundNight.SetActive(false);

        OnStartLevel?.Invoke();
    }

/*    public void Run() //start level
    {
        Manager.Instance.dialogueManager.StartDialog(Dialogues[level]); //start dialog on every level begin
        Manager.Instance.menuManager.HideAllMenuParts();

        Invoke(nameof(StartLevelLogic),Manager.Instance.dialogueManager.currentDialog.GetSumDialogueTime());

        
    }*/

    public void EndLevelLogic(/*any result of game*/) //end level
    {
        level++;
        OnFinishLevel?.Invoke();
    }
}

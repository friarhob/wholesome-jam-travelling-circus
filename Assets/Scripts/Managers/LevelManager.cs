using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public event UnityAction OnStartLevel;
    public event UnityAction OnFinishLevel;

    public float levelTime { get; private set; } //time from level begin

    private void Start()
    {
        Manager.Instance.currentLevel = this;
        levelTime = 0;
    }
    public void Run()           //start game
    {

        OnStartLevel?.Invoke();
    }

    public void End(/*any result of game*/)          //end game
    {
        OnFinishLevel?.Invoke();
    }
}

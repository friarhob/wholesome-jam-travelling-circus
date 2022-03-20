using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private bool levelRunning;
    private int level;
    public float remainingTime;

    public GameObject backgroundDay;
    public GameObject foregroundDay;
    public GameObject backgroundNight;
    public GameObject foregroundNight;

    void Start()
    {
        levelRunning = false;
        level = 1;

        StartLevel();
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


    private void StartLevel()
    {
        level++;
        levelRunning = true;
        remainingTime = 10f - level;

        backgroundDay.SetActive(true);
        foregroundDay.SetActive(true);
        backgroundNight.SetActive(false);
        foregroundNight.SetActive(false);
    }

}

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

    public GameObject nessieImage;
    public GameObject unicornImage;
    public GameObject chimeraImage;
    public GameObject gryphonImage;

    void Start()
    {
        levelRunning = false;
        level = 1;

        nessieImage.SetActive(true);
        unicornImage.SetActive(false);
        chimeraImage.SetActive(false);
        gryphonImage.SetActive(false);
        
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

    public void BuyAnimal(Creature creature)
    {
        if(creature == Creature.Nessie) nessieImage.SetActive(true);
        if(creature == Creature.Unicorn) unicornImage.SetActive(true);
        if(creature == Creature.Chimera) chimeraImage.SetActive(true);
        if(creature == Creature.Gryphon) gryphonImage.SetActive(true);
    }

    public void StartLevel()
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

public enum Creature {Nessie, Unicorn, Chimera, Gryphon};
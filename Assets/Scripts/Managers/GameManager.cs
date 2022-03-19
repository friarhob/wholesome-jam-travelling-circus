using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public SoundManager soundManager;
    public MenuManager menuManager;
    public GameObject mainMenuCanvas;
    public GameObject[] introDialogueCanvases;
    private int currentIntroDialogue;
    bool levelRunning;
    float remainingTime;
    int level;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuCanvas.SetActive(true);
        currentIntroDialogue = 0;
        levelRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (levelRunning)
        {
            remainingTime -= Time.deltaTime;
            if (remainingTime < 0)
            {
                levelRunning = false;
                // TODO: add night time;
            }
        }
    }

    public void StartGame()
    {
        mainMenuCanvas.SetActive(false);
        Invoke("LoadIntroDialogue", 1f);
    }

    private void LoadIntroDialogue()
    {
        if (currentIntroDialogue > 0)
        {
            introDialogueCanvases[currentIntroDialogue - 1].SetActive(false);
        }

        if (currentIntroDialogue < introDialogueCanvases.Length)
        {
            introDialogueCanvases[currentIntroDialogue].SetActive(true);
            currentIntroDialogue++;
            Invoke("LoadIntroDialogue", 4f);
        }
        else
        {
            RunGame();
        }

    }

    private void RunGame()
    {
        SceneManager.LoadScene("GameScene");
        levelRunning = true;
        level = 1;
        remainingTime = 10f - level;
    }
}

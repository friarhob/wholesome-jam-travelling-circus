using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public SoundManager soundManager;
    public GameObject mainMenuCanvas;
    public GameObject[] introDialogueCanvases;
    private int currentIntroDialogue;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuCanvas.SetActive(true);
        currentIntroDialogue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        mainMenuCanvas.SetActive(false);
        Invoke("LoadIntroDialogue", 1f);
    }

    private void LoadIntroDialogue()
    {
        if(currentIntroDialogue > 0)
        {
            introDialogueCanvases[currentIntroDialogue-1].SetActive(false);
        }

        if(currentIntroDialogue < introDialogueCanvases.Length)
        {
            introDialogueCanvases[currentIntroDialogue].SetActive(true);
            currentIntroDialogue++;
            Invoke("LoadIntroDialogue", 4f);
        }
        else
        {
            SceneManager.LoadScene("GameScene");
        }
        
    }
}

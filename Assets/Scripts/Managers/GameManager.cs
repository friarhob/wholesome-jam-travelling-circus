using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance { get; private set; }

    public SoundManager soundManager;
    public MenuManager menuManager;
    public DialogueManager dialogueManager;

    void Awake()
    {
        Instance = Instance ? Instance : this;
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void StartGame()
    {
        dialogueManager.RunDialogue();
    }
}

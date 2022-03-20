using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    
    //you can get any manager(sound,menu,anything) for  each levelManager from this GLOBAL manager
    public static Manager Instance { get; private set; }

    public SoundManager soundManager;
    public MenuManager menuManager;
    public DialogsManager dialogueManager;

    public LevelManager currentLevel;


    private void Awake()
    {
        Instance = Instance ? Instance : this;
    }
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void LoadLevel() //load any level, i think
    {
        SceneManager.LoadScene("GameScene");
    }

    void LoadGameScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
 
}

using UnityEngine;
using UnityEngine.UI;


public class MusicSwitcherButton : MonoBehaviour
{

    private bool MusicEnabled;
    [SerializeField]
    private Image ButtonImage;
    [SerializeField] private Sprite MusicOnSprite;
    [SerializeField] private Sprite MusicOffSprite;

    void Start()
    {
        MusicEnabled = true;
    }



    public void SwitchMusic()
    {
        if (MusicEnabled)
        {
            ButtonImage.sprite = MusicOnSprite;
        }
        else
        {
            ButtonImage.sprite = MusicOffSprite;
        }
        MusicEnabled = !MusicEnabled;
    }
}

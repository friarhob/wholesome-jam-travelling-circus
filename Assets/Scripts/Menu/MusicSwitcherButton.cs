using UnityEngine;
using TMPro;


public class MusicSwitcherButton : MonoBehaviour
{

    private bool MusicEnabled;
    [SerializeField]
    private TextMeshProUGUI ButtonText;

    void Start()
    {
        MusicEnabled = true;
    }

    

    public void SwitchMusic()
    {
        if(MusicEnabled)
        {
            ButtonText.text = "Music On";
        }
        else
        {
            ButtonText.text = "Music Off";
        }
        MusicEnabled = !MusicEnabled;
    }
}

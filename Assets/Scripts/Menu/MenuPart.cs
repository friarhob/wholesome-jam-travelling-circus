using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public partial class MenuPart : MonoBehaviour
{

    [SerializeField]
    MenuPartType partType;
    [SerializeField]
    GameManager gameManager;

    private void Start()
    {
        if (!gameManager.menuManager.MenuParts.Contains(this))
        {
            gameManager.menuManager.MenuParts.Add(this);
        }
    }
    public MenuPartType PartType { get { return partType; } private set { } }
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
}
public enum MenuPartType : int
{
    Home,
    Settings,
    HowToPlay,
    Credits
}

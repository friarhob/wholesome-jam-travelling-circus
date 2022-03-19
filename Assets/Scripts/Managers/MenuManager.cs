using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
   
    public List<MenuPart> MenuParts = new List<MenuPart>();
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    public void LoadMenuPart(string menuType)
    {
        HideAllMenuParts();
        MenuPartType partType;
        MenuParts.Find(p => p.PartType == (MenuPartType)Enum.Parse(typeof(MenuPartType), menuType)).Show();
    }

    public void LoadMenuPart(MenuPart menuPart)
    {
        HideAllMenuParts();
        menuPart.Show();
    }

    public void HideAllMenuParts()
    {
        foreach(MenuPart mp in MenuParts)
        {
            mp.Hide();
        }
    }
    
}

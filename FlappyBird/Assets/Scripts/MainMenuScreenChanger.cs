using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScreenChanger : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject OptionsMenu;
    // Start is called before the first frame update
    public void LoadMainMenuSceneFromOptions()
    {
        MainMenu.SetActive(true);
        OptionsMenu.SetActive(false);
    }
    public void LoadOptionSceneFromMenu()
    {
        MainMenu.SetActive(false);
        OptionsMenu.SetActive(true);
    }
}

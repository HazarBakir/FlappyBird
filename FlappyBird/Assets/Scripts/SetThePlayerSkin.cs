using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetThePlayerSkin : MonoBehaviour
{

    private int changeSkinNumber;
    private void Start()
    {
        changeSkinNumber= PlayerPrefs.GetInt("ChangePlayerSkin");
    }
    public void DropdownPlayerChangeSkin(int index)
    {
        switch (index)
        {
            case 0:
                PlayerPrefs.SetInt("ChangePlayerSkin", index);
                break; 
            case 1:
                PlayerPrefs.SetInt("ChangePlayerSkin", index);
                break;
            case 2:
                PlayerPrefs.SetInt("ChangePlayerSkin", index);
                break;
            default:
                PlayerPrefs.SetInt("ChangePlayerSkin", 0);
                break;
        }
    }
}

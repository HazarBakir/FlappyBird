using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeThePlayerSkin : MonoBehaviour
{
    private int changeSkinNumber = PlayerPrefs.GetInt("ChangePlayerSkin");
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

    public void SetChangeSkin()
    {
        if (changeSkinNumber == 0) 
        {
            //create the first Player Skin
        }
        else if (changeSkinNumber == 1)
        {
            //create the second Player Skin
        }
        else if(changeSkinNumber == 2)
        {
            // THIRD !
        }
        else
        {
            // create the Default Player Skin
        }
    }


}

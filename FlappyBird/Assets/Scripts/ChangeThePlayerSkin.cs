using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeThePlayerSkin : MonoBehaviour
{
    public GameObject playerFirst;
    public GameObject playerSecond;
    public GameObject playerThird;
    private int changeSkinNumber;   
    // Start is called before the first frame update
    void Start()
    {
        changeSkinNumber = PlayerPrefs.GetInt("ChangePlayerSkin");
        SetChangeSkin();
    }
    public void SetChangeSkin()
    {
        if (changeSkinNumber == 0)
        {
            //create the first Player Skin
            Debug.Log("0");
            Instantiate(playerFirst, new Vector3(-10.51f, 5.39f, 0), Quaternion.identity);
        }
        else if (changeSkinNumber == 1)
        {
            Debug.Log("1");
            //create the second Player Skin
        }
        else if (changeSkinNumber == 2)
        {
            Debug.Log("2");

            // THIRD !
        }
        else
        {
            Debug.Log("100");
            // create the Default Player Skin
        }
    }
}

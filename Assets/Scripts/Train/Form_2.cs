using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Form_2 : MonoBehaviour {

    private GameObject parent;
    private string[] setting;

	// Use this for initialization
	void Start ()
    {
        int index = 0;

        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            for (int ii = 0; ii < gameObject.transform.GetChild(i).transform.childCount; ii++)
            {

                if (gameObject.transform.GetChild(i).transform.GetChild(ii).name == "Placeholder")
                {
                    // gameObject.transform.GetChild(i).transform.GetChild(ii).GetComponent<DeviceMain>().deviceSettings.settings[index] = parent.GetComponent<DeviceMain>().deviceSettings.settings[index];
                    index++;
                }


            }
        }
    }

    public void Cancel()
    {
        Destroy(gameObject);
    }
    public void Save()
    {
        int index = 0;
        string[] _str = new string[7];
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            for (int ii = 0; ii < gameObject.transform.GetChild(i).transform.childCount; ii++)
            {
                if (gameObject.transform.GetChild(i).transform.GetChild(ii).name == "input")
                {
                    _str[index] = gameObject.transform.GetChild(i).transform.GetChild(ii).GetComponent<Text>().text;
                    index++;
                }
            }
        }
        if(index==7)
        {
            // parent.GetComponent<DeviceMain>().deviceSettings.settings = _str;
            Destroy(gameObject);
        }
    }
}

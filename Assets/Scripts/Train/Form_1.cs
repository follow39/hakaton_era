using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Form_1 : MonoBehaviour {

    private string[] inputFields = new string[4]; 
	public void Cancel()
    {
        Destroy(gameObject);
    }
    public void Save()
    {
        int index = 0;
        for(int i=0; i<gameObject.transform.childCount;i++)
        {
            for(int ii=0; ii<gameObject.transform.GetChild(i).transform.childCount;ii++)
            {
                for(int iii=0;iii< gameObject.transform.GetChild(i).transform.GetChild(ii).transform.childCount;iii++)
                {
                    if (gameObject.transform.GetChild(i).transform.GetChild(ii).transform.GetChild(iii).name == "input")
                    {
                        inputFields[index] = gameObject.transform.GetChild(i).transform.GetChild(ii).transform.GetChild(iii).GetComponent<Text>().text;
                        index++;
                    }
                }
                
            }
        }
        
    }
}

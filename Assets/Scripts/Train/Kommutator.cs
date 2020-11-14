using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kommutator : MonoBehaviour {

    private GameObject[] children = new GameObject[8];
	void Start ()
    {
		for(int i=0; i<8;i++)
        {
            children[i] = gameObject.transform.GetChild(i).gameObject;
        }
	}
	
	
}

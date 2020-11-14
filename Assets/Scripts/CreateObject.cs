using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateObject : MonoBehaviour
{
	public GameObject prefabObj;

	// Use this for initialization
	void Start ()
	{
		gameObject.GetComponent<Button>().onClick.AddListener(OnCLickButton);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnCLickButton()
	{
		GameObject temp = Instantiate(prefabObj, new Vector3(500, 250, 0), Quaternion.identity) as GameObject;
		temp.transform.SetParent(GameObject.Find("WorkPanel").transform, true);
	}
}

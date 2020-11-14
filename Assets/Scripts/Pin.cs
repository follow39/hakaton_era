using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pin : MonoBehaviour 
{
	public GameObject ConnectionPrefab;
	Button button;

	// Use this for initialization
	void Start () 
	{
		button = gameObject.transform.Find("Button").GetComponent<Button>();
		button.onClick.AddListener(OnClickButton);		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}	

	void OnClickButton()
	{
		if (ProgramData.CurrentConnection == null)
		{
			GameObject new_connection = Instantiate(ConnectionPrefab) as GameObject;
			new_connection.GetComponent<Connection>().pin1 = gameObject;//.transform.Find("PinObject").gameObject;
			ProgramData.CurrentConnection = new_connection;
			new_connection.transform.SetParent(GameObject.Find("WorkPanel").transform, true);
		}
		else
		{
			ProgramData.CurrentConnection.GetComponent<Connection>().pin2 = gameObject;
			ProgramData.CurrentConnection = null;
		}
	}
}

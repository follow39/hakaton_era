using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class UserPanel : MonoBehaviour 
{
	public InputField loginField;
	public InputField groupField;
	public Button enterButton;

	// Use this for initialization
	void Start () 
	{
		enterButton.onClick.AddListener(OnButtonEnterClick);		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnButtonEnterClick()
	{
		// Debug.Log(loginField.text);
		// Debug.Log(groupField.text);

		//send data--------------------------------
		// "\n	'login' : {loginField.text},\n	'pass' : {passwordField.text}\n"
		string jsonData = "{\n	'login' : ";
		jsonData += loginField.text;
		jsonData += ",\n	'pass' : ";
		jsonData += groupField.text;
		jsonData += "\n}";

		UnityWebRequest.Post(ProgramData.URL, jsonData);

		Debug.Log(jsonData.ToString());
		//send data--------------------------------
		
		//get data---------------------------------
		UnityWebRequest myWr = UnityWebRequest.Get(ProgramData.URL);
		//get data---------------------------------

		//save data--------------------------------
		ProgramData.login = loginField.text;
		//save data--------------------------------
		
		SceneManager.LoadScene("LevelScene");
	}
}

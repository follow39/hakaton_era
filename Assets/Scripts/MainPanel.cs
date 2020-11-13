using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainPanel : MonoBehaviour
{
	public GameObject adminPanel;
	public GameObject userPanel;
	public Dropdown adminMode;
	// public Scene

	// Use this for initialization
	void Start ()
	{
		adminMode.onValueChanged.AddListener(delegate {onValueAdminModeChanged(adminMode);});
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void onValueAdminModeChanged(Dropdown changedDropDown)
	{
		Debug.Log(changedDropDown.value);

		switch(changedDropDown.value)
		{
			case (int)UserType.User:
				adminPanel.SetActive(false);
				userPanel.SetActive(true);
				break;
			case (int)UserType.Admin:
				adminPanel.SetActive(true);
				userPanel.SetActive(false);
				break;
		}
	}
}
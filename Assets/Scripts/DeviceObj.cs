using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DeviceObj : MonoBehaviour, IPointerExitHandler
{
	public Button button;

	// Use this for initialization
	void Start ()
	{
		// button = gameObject.transform.Find("Button").GetComponent<Button>();
		button.onClick.AddListener(OnClickButton);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnClickButton()
	{
		gameObject.transform.Find("Panel").gameObject.SetActive(true);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		gameObject.transform.Find("Panel").gameObject.SetActive(false);
	}
}

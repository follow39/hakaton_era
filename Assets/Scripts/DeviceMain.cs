using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DeviceMain : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool dragging = false;
    public DeviceSettings deviceSettings;

    // Use this for initialization
    void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (dragging)
		{
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
		
	}

    public void OnPointerDown(PointerEventData eventData)
	{
        dragging = true;
    }

    public void OnPointerUp(PointerEventData eventData)
	{
        dragging = false;
    }
}

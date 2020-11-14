using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DeviceMain : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool dragging = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
        if (dragging)
		{
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
		
	}

	
    // public void OnMouseDrag()
	// {		
    // 	Vector3 point;
	// 	float x;
	// 	float y;
	// 	float z;
		
    //     x = Input.mousePosition.x;
    //     y = Input.mousePosition.y;
    //     z = gameObject.transform.position.z;

    //     point = Camera.main.ScreenToWorldPoint (new Vector3 (x, y, z));
    //     gameObject.transform.position = point;
	// }

    public void OnPointerDown(PointerEventData eventData)
	{
        dragging = true;
    }

    public void OnPointerUp(PointerEventData eventData)
	{
        dragging = false;
    }
}

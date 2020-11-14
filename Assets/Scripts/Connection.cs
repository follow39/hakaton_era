﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Connection : MonoBehaviour
{
	public GameObject pin1 = null;
	public GameObject pin2 = null;

	LineRenderer line;
	bool IsFinished = false;

	// Use this for initialization
	void Start ()
	{
		line = gameObject.GetComponent<LineRenderer>();
		line.startWidth = 10f;
		line.endWidth = 10f;
		line.sortingLayerName = "Foreground";
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(pin1 == null)
		{
			return;
		}		

		if(IsFinished)
		{

		}
		else
		{
			line.SetPosition(0, pin1.transform.position + new Vector3(0, 0, -10f));
			// line.SetPosition(0, new Vector3(0, 0, 0));
			// line.SetPosition(1, new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
			line.SetPosition(1, Input.mousePosition + new Vector3(0, 0, -10f));
			// Debug.Log(line.GetPosition(0));
			// Debug.Log(line.GetPosition(1));
			
			if (Input.GetMouseButtonDown(1))
			{
				Destroy(gameObject);
			}

			if(pin2 != null)
			{
				IsFinished = true;
				line.SetPosition(1, pin2.transform.position);
			}
		}
	}
}

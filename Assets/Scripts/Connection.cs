using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
	}
	
	// Update is called once per frame
	void Update ()
	{
		if(IsFinished || pin1 == null)
		{

		}
		else
		{
			line.SetPosition(0, pin1.transform.position);
			line.SetPosition(1, new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
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

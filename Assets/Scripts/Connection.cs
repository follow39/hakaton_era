using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour
{
	public GameObject pin1 = null;
	public GameObject pin2 = null;
	public GameObject LineObject;
	LineRenderer line;
	bool IsFinished = false;

	// Use this for initialization
	void Start ()
	{
		line = gameObject.GetComponent<LineRenderer>();
		line.startWidth = 0.1f;
		line.endWidth = 0.1f;
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
			line.SetPosition(0, pin1.transform.position);
			// line.SetPosition(0, new Vector3(0, 0, 0));
			// line.SetPosition(1, new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
			line.SetPosition(1, Input.mousePosition);
			// Debug.Log(line.GetPosition(0));
			// Debug.Log(line.GetPosition(1));
			
			if (Input.GetMouseButtonDown(1))
			{
				Destroy(gameObject);
			}

			if(pin2 != null)
			{
				IsFinished = true;
				// line.SetPosition(1, pin2.transform.position);
			}
		}
	}
	private void DrawLine(Vector2 pointA, Vector2 pointB)
	{
		float lineWidth = 2;
	
		Vector3 differenceVector = pointB - pointA;
		// var line = Instantiate(prefabLine, this.GetComponent<Transform>());
		var imageRectTransform = line.GetComponent<RectTransform>();
		imageRectTransform.sizeDelta = new Vector2(differenceVector.magnitude / CenterImg.canvas.scaleFactor, lineWidth);
		imageRectTransform.pivot = new Vector2(0, 0.5f);
		imageRectTransform.localPosition = new Vector3(pointA.x, pointA.y, CenterImg.transform.position.z);
		float angle = Mathf.Atan2(differenceVector.y, differenceVector.x) * Mathf.Rad2Deg;
		line.transform.localRotation = Quaternion.Euler(0, 0, angle);
	}
}

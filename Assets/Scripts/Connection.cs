using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Connection : MonoBehaviour
{
	public GameObject pin1;
	public GameObject pin2;

	LineRenderer line;

	// Use this for initialization
	void Start ()
	{
		line.SetPosition(0, pin1.transform.position);
		
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}

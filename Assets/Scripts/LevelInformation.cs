using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelInformation
{
	public string name{get; set;}
	public bool state{get; set;}
	public int id{get; set;}
	public LevelInformation(string _name, bool _state, int _id)
	{
		name = _name;
		state = _state;
		id = _id;
	}

}

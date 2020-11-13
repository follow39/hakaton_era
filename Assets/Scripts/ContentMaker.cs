using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentMaker : MonoBehaviour
{
	public GameObject scrollItem;

	int xStart = 310;
	int yStart = -50;

	// Use this for initialization
	void Start ()
	{
		//get data---------------------------------
		ProgramData.levelsList.Add(new LevelInformation("Задание 1. Электро", true, 1));
		ProgramData.levelsList.Add(new LevelInformation("Задание 2. Электро", false, 2));
		ProgramData.levelsList.Add(new LevelInformation("Задание 3. Электро", false, 3));
		//get data---------------------------------
		
		//filling scroll---------------------------
		int x = xStart;
		int y = yStart;
		int count = 0;
		foreach (LevelInformation level in ProgramData.levelsList)
		{
			count++;
			GameObject temp = Instantiate(scrollItem, new Vector3(0, 0, 0), Quaternion.identity) as GameObject;
			temp.transform.SetParent(gameObject.transform, true);
			temp.transform.position += gameObject.transform.position;
			temp.transform.position += new Vector3(x, y, 0);
			temp.name = "ScrollItem" + count;
			
			temp.transform.Find("Panel").transform.Find("LevelName").GetComponent<Text>().text = level.name;
			temp.transform.Find("Panel").transform.Find("LevelState").GetComponent<Text>().text = level.state? "Выполнено" : "Не решено";

			y -= 50;
		}
		//filling scroll---------------------------		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}

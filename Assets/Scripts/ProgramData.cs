using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum UserType
{
	User = 0,
	Admin = 1
}

public static class ProgramData
{
	public const string URL = "";
	public static string login;
    public static UserType CurrentUserType;
	public static int level;
	public static List<LevelInformation> levelsList = new List<LevelInformation>();
	public static GameObject CurrentConnection = null; 
	public static List<GameObject> connectionList = new List<GameObject>();
}

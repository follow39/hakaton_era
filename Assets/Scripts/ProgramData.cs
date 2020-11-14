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
<<<<<<< HEAD
    public static List<GameObject> Devices = new List<GameObject>();

=======
>>>>>>> 0919fcb3a2e1f5a5960bcf275ea859b770c04e45
	public static GameObject CurrentConnection = null; 
	public static List<Connection> connectionList = new List<Connection>();
}

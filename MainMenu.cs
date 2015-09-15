using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	public void Button (string level)
	{
		Maze.cookies = 0;
		Application.LoadLevel(level);
	}
}

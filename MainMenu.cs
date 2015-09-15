using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
	public void Button (string level)
	{
		Application.LoadLevel(level);
	}
}

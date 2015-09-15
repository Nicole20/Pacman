using UnityEngine;
using System.Collections;

public class Cookie : MonoBehaviour
{
	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		if(hitInfo.tag == "Player")
		{
			Maze.cookies--;
			Destroy(gameObject);
		}
	}
}

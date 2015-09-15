using UnityEngine;
using System.Collections;

public class Collision : MonoBehaviour
{
	public Rigidbody2D pacman, ghost;

	void OnTriggerEnter2D (Collider2D hitInfo)
	{
		if(hitInfo.tag == "Wall")
		{
			if(gameObject.name == "Left")
			{
				if(pacman.transform.position.y > ghost.transform.position.y)
				{
					//move up
					Ghost_AI.move_next = 2;
				}
				else if(pacman.transform.position.y < ghost.transform.position.y)
				{
					//move down
					Ghost_AI.move_next = 3;
				}
				else
				{
					//move left
					Ghost_AI.move_next = 0;
				}
			}
			else if(gameObject.name == "Right")
			{
				if(pacman.transform.position.y > ghost.transform.position.y)
				{
					//move up
					Ghost_AI.move_next = 2;
				}
				else if(pacman.transform.position.y < ghost.transform.position.y)
				{
					//move down
					Ghost_AI.move_next = 3;
				}
				else
				{
					//move right
					Ghost_AI.move_next = 1;
				}
			}
			else if(gameObject.name == "Top")
			{
				if(pacman.transform.position.x > ghost.transform.position.x)
				{
					//move right
					Ghost_AI.move_next = 1;
				}
				else if(pacman.transform.position.x < ghost.transform.position.x)
				{
					//move left
					Ghost_AI.move_next = 0;
				}
				else
				{
					//move down
					Ghost_AI.move_next = 3;
				}
			}
			else if(gameObject.name == "Bottom")
			{
				if(pacman.transform.position.x > ghost.transform.position.x)
				{
					//move right
					Ghost_AI.move_next = 1;
				}
				else if(pacman.transform.position.x < ghost.transform.position.x)
				{
					//move left
					Ghost_AI.move_next = 0;
				}
				else
				{
					//move up
					Ghost_AI.move_next = 2;
				}
			}
		}
		else if(hitInfo.tag == "Player")
		{
			Application.LoadLevel("GameOver");
		}
	}
}

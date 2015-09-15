using UnityEngine;
using System.Collections;

public class Ghost_AI : MonoBehaviour
{
	float speed = 0.8f;
	float x_diff, y_diff;
	static public int move_curr, move_next;
	public Rigidbody2D pacman;
	
	IEnumerator Start () 
	{
		yield return new WaitForSeconds(2f);
		
		move_next = Random.Range (0, 4);  //0 to 3
		move_curr = move_next;

		switch(move_curr)
		{
		case 0:
			rigidbody2D.velocity = new Vector2(-speed, 0);
			break;
		case 1:
			rigidbody2D.velocity = new Vector2(speed, 0);
			break;
		case 2:
			rigidbody2D.velocity = new Vector2(0, speed);
			break;
		case 3:
			rigidbody2D.velocity = new Vector2(0, -speed);
			break;
		default:
			break;
		}
	}

	void Update ()
	{
		if(move_curr != move_next)
		{
			switch(move_curr)
			{
			case 0:
				rigidbody2D.velocity = new Vector2(-speed, 0);
				break;
			case 1:
				rigidbody2D.velocity = new Vector2(speed, 0);
				break;
			case 2:
				rigidbody2D.velocity = new Vector2(0, speed);
				break;
			case 3:
				rigidbody2D.velocity = new Vector2(0, -speed);
				break;
			default:
				break;
			}

			move_curr = move_next;
		}
		else
		{
			x_diff = pacman.transform.position.x - rigidbody2D.transform.position.x;
			y_diff = pacman.transform.position.y - rigidbody2D.transform.position.y;

			if(x_diff > 4)
			{
				rigidbody2D.velocity = new Vector2(speed, 0);
			}
			else if(x_diff < -4)
			{
				rigidbody2D.velocity = new Vector2(-speed, 0);
			}
			else if(y_diff > 4)
			{
				rigidbody2D.velocity = new Vector2(0, speed);
			}
			else if(y_diff < -4)
			{
				rigidbody2D.velocity = new Vector2(0, -speed);
			}
		}
	}
}

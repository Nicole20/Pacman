using UnityEngine;
using System.Collections;

public class PacManControl : MonoBehaviour
{
	public KeyCode up, down, left, right;
	
	float speed = 1.5f;

	IEnumerator Start () 
	{
		yield return new WaitForSeconds(2f);
		animation.Play ();
		rigidbody2D.velocity = new Vector2(speed, 0);
	}

	void Update ()
	{
		if(Input.GetKey(up))
		{
			rigidbody2D.velocity = new Vector2(0, speed);
			rigidbody2D.rotation = 90;
			animation.Play ();
		}
		else if(Input.GetKey(down))
		{
			rigidbody2D.velocity = new Vector2(0, -speed);
			rigidbody2D.rotation = -90;
			animation.Play ();
		}
		else if(Input.GetKey(left))
		{
			rigidbody2D.velocity = new Vector2(-speed, 0);
			rigidbody2D.rotation = 180;
			animation.Play ();
		}
		else if(Input.GetKey(right))
		{
			rigidbody2D.velocity = new Vector2(speed, 0);
			rigidbody2D.rotation = 0;
			animation.Play ();
		}
	}

	void OnCollisionEnter2D (Collision2D colInfo)
	{
		rigidbody2D.velocity = new Vector2 (0, 0);
		animation.Stop ();
	}
}

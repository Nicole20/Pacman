using UnityEngine;
using System.Collections;

public class Maze : MonoBehaviour
{
	public GameObject ver, hor, block, cookie;

	int wall;
	static public int cookies = 0;

	public GameObject pacman, ghost;

	void Start()
	{
		for(int i = 0; i < 7; i++)
		{
			for(int j = 0; j < 7; j++)
			{
				if(i == 0)
				{
					Instantiate(ver, new Vector3(i, j, 0), Quaternion.identity);
					Instantiate(ver, new Vector3(i, j + 0.4f, 0), Quaternion.identity);
					Instantiate(ver, new Vector3(i, j + 0.8f, 0), Quaternion.identity);
				}
				if(i == 6)
				{
					Instantiate(ver, new Vector3(i + 1, j, 0), Quaternion.identity);
					Instantiate(ver, new Vector3(i + 1, j + 0.4f, 0), Quaternion.identity);
					Instantiate(ver, new Vector3(i + 1, j + 0.8f, 0), Quaternion.identity);
				}

				if(j == 0)
				{
					Instantiate(hor, new Vector3(i, j, 0), Quaternion.identity);
					Instantiate(hor, new Vector3(i + 0.4f, j, 0), Quaternion.identity);
					Instantiate(hor, new Vector3(i + 0.8f, j, 0), Quaternion.identity);
				}
				if(j == 6)
				{
					Instantiate(hor, new Vector3(i, j + 1, 0), Quaternion.identity);
					Instantiate(hor, new Vector3(i + 0.4f, j + 1, 0), Quaternion.identity);
					Instantiate(hor, new Vector3(i + 0.8f, j + 1, 0), Quaternion.identity);
				}

				wall = Random.Range(0, 4);  //0 to 3

				if(wall == 0)
				{
					Instantiate(block, new Vector3(i, j, 0), Quaternion.identity);

					wall = Random.Range(0, 3);  //0 to 2
					switch(wall)
					{
					case 0:
						Instantiate(cookie, new Vector3(i + 0.75f, j + 0.75f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.25f, j + 0.75f, 0), Quaternion.identity);
						break;
					case 1:
						Instantiate(cookie, new Vector3(i + 0.75f, j + 0.25f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.25f, j + 0.75f, 0), Quaternion.identity);
						break;
					case 2:
						Instantiate(cookie, new Vector3(i + 0.75f, j + 0.25f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.75f, j + 0.75f, 0), Quaternion.identity);
						break;
					default:
						break;
					}
					cookies += 2;
				}
				else if(wall == 1)
				{
					Instantiate(ver, new Vector3(i, j, 0), Quaternion.identity);
					Instantiate(cookie, new Vector3(i + 0.25f, j + 0.25f, 0), Quaternion.identity);

					cookies++;

					wall = Random.Range(0, 4);  //0 to 3
					if(wall == 0)
					{
						if(j + 0.4f < 7)
						{
							Instantiate(ver, new Vector3(i, j + 0.4f, 0), Quaternion.identity);
							Instantiate(cookie, new Vector3(i + 0.25f, j + 0.75f, 0), Quaternion.identity);

							cookies++;
						}
					}
					else if(wall == 1)
					{
						if(i < 7)
						{
							Instantiate(hor, new Vector3(i, j, 0), Quaternion.identity);
							Instantiate(cookie, new Vector3(i + 0.25f, j + 0.25f, 0), Quaternion.identity);
							Instantiate(cookie, new Vector3(i + 0.25f, j + 0.75f, 0), Quaternion.identity);

							cookies += 2;
						}
					}
					else if(wall == 2)
					{
						if(i > 0)
						{
							Instantiate(hor, new Vector3(i - 0.4f, j, 0), Quaternion.identity);
							Instantiate(cookie, new Vector3(i - 0.25f, j + 0.25f, 0), Quaternion.identity);

							cookies++;
						}
					}
				}
				else if(wall == 2)
				{
					Instantiate(hor, new Vector3(i, j, 0), Quaternion.identity);
					Instantiate(cookie, new Vector3(i + 0.25f, j + 0.25f, 0), Quaternion.identity);

					cookies++;

					wall = Random.Range(0, 4);  //0 to 3
					if(wall == 0)
					{
						if(i + 0.4f < 7)
						{
							Instantiate(hor, new Vector3(i + 0.4f, j, 0), Quaternion.identity);
							Instantiate(cookie, new Vector3(i + 0.75f, j + 0.25f, 0), Quaternion.identity);

							cookies++;
						}
					}
					else if(wall == 1)
					{
						Instantiate(ver, new Vector3(i, j, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.25f, j + 0.25f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.25f, j + 0.75f, 0), Quaternion.identity);

						cookies += 2;
					}
					else if(wall == 2)
					{
						if(j > 0)
						{
							Instantiate(ver, new Vector3(i, j - 0.4f, 0), Quaternion.identity);
							Instantiate(cookie, new Vector3(i + 0.25f, j - 0.25f, 0), Quaternion.identity);

							cookies++;
						}
					}
				}
				else
				{
					wall = Random.Range(0, 4);  //0 to 3
					switch(wall)
					{
					case 0:
						Instantiate(cookie, new Vector3(i + 0.75f, j + 0.25f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.75f, j + 0.75f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.25f, j + 0.75f, 0), Quaternion.identity);
						break;
					case 1:
						Instantiate(cookie, new Vector3(i + 0.25f, j + 0.25f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.75f, j + 0.75f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.25f, j + 0.75f, 0), Quaternion.identity);
						break;
					case 2:
						Instantiate(cookie, new Vector3(i + 0.25f, j + 0.25f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.75f, j + 0.25f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.25f, j + 0.75f, 0), Quaternion.identity);
						break;
					case 3:
						Instantiate(cookie, new Vector3(i + 0.25f, j + 0.25f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.75f, j + 0.25f, 0), Quaternion.identity);
						Instantiate(cookie, new Vector3(i + 0.75f, j + 0.75f, 0), Quaternion.identity);
						break;
					default:
						break;
					}

					cookies += 3;
				}
			}
		}

		pacman.transform.position = new Vector2 (1, 1);
		ghost.transform.position = new Vector2 (4, 4);
	}

	void Update()
	{
		if(cookies == 0)
		{
			Application.LoadLevel("Pacman");
		}
	}
}

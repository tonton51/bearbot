using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doorendtest : MonoBehaviour
{
	public Animator openandclose;
	public bool open;
	public Transform Player;

	void Start()
	{
		open = false;
	}

	void OnMouseOver()
	{
		{
			if (Player)
			{
				float dist = Vector3.Distance(Player.position, transform.position);
				if (dist < 15)
				{
					if (open == false)
					{
						if (Input.GetMouseButtonDown(0))
						{
							StartCoroutine(opening());

						}
					}
					else
					{
						if (open == true)
						{
							if (Input.GetMouseButtonDown(0))
							{
								StartCoroutine(closing());
							}
						}

					}

				}
			}

		}

	}

	IEnumerator opening()
	{
		print("you are opening the door");
		openandclose.Play("Opening");
		open = true;
		SceneManager.LoadScene("GameClear");
		yield return new WaitForSeconds(.5f);
	}

	IEnumerator closing()
	{
		print("you are closing the door");
		openandclose.Play("Closing");
		open = false;
		yield return new WaitForSeconds(.5f);
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class keydoor : MonoBehaviour
{
    

	public Animator openandclose;
	public bool open;
	public Transform Player;
	public GameObject key;
	bool keyopen=false;
	public Itemtouchtest itemtouchtest;
	float second = 0;
	int count = 0;
	protected string currentScene;  // åªç›ÇÃÉVÅ[Éì

	void Start()
	{
		open = false;
		keyopen = false;
		

	}

	void Update()
    {
		keyopen = itemtouchtest.keyget;
		Debug.Log(keyopen);
		currentScene = SceneManager.GetActiveScene().name;
		Debug.Log(currentScene);

	}

	public void Doormove()
	{
		Debug.Log("doormove");
		{
			if (Player)
			{
				
				float dist = Vector3.Distance(Player.position, transform.position);
				if (dist < 15)
				{
					
					if (keyopen)
					{

						if (open == false)
						{
							Debug.Log("Ç†ÇØÇÊÇ§Ç∆Ç∑ÇÈ");
							
							StartCoroutine(opening());
							if (currentScene == "fastfoodescape")
							{
								SceneManager.LoadScene("GameClear");
							}
							else if (currentScene == "story2nd")
							{
								SceneManager.LoadScene("story3rd");
							}

						}

					}
					else
					{
						Debug.Log("ãÛÇ©Ç»Ç¢");
						if (open == false)
						{
							Debug.Log("Ç†ÇØÇÊÇ§Ç∆Ç∑ÇÈ");

							
							if (currentScene == "fastdfoodescape")
							{
								SceneManager.LoadScene("GameClear");
							}
							else if (currentScene == "story2nd")
							{
								SceneManager.LoadScene("story3rd");
							}

						}
						if (open == true)
						{
							StartCoroutine(closing());


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



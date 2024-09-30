using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SojaExiles

{
	public class opencloseDoor : MonoBehaviour
	{

		public Animator openandclose;
		public bool open;
		public Transform Player;
		protected string currentScene;  // 現在のシーン

		void Start()
		{
			open = false;
			currentScene = SceneManager.GetActiveScene().name;
			Debug.Log("start");
			Debug.Log(currentScene);
			if (currentScene == "story3rd")
			{
				StartCoroutine(opening());
			}
		}
		

		public void OnMouseOver()
		{

			//if (Player)
			//{
			Debug.Log("振れた");
			Debug.Log(open);
					
						if (open == false)
						{
							
								StartCoroutine(opening());
								Debug.Log("あける");
	
						}
						
							if (open == true)
							{
								
									StartCoroutine(closing());
								
							}

						

					
				//}

			

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
}
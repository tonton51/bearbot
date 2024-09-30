using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sitanimation : MonoBehaviour
{
	Animation anim;

	// Use this for initialization
	void Start()
	{
		anim = this.gameObject.GetComponent<Animation>();
		anim.Play();
	}
}

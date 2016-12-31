using UnityEngine;
using System.Collections;

public class ipspeed : MonoBehaviour 
{
	private Animator anim;

	void Start () 
	{
		anim = gameObject.GetComponent<Animator> ();
	}

	void Update () 
	{
		if(Input.GetMouseButton(0))
		{
			anim.speed = 2f;
		}
		else
		{
			anim.speed = 2f;
		}
	}
}
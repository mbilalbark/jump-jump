using UnityEngine;
using System.Collections;

public class tuş : MonoBehaviour {

	// Use this for initialization
	public void yenisahne (int hangisi) {
		Application.LoadLevel (hangisi);
	
	}
	
	// Update is called once per frame
	public void Oyundancık () {
		Application.Quit ();
	
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Interaction : MonoBehaviour {
	public float interval;
	// Use this for initialization
	void Start () {
		float my_int = this.gameObject.GetComponent<SmoothMouseLook> ().frameCounter;
		Debug.Log ("Variabila atribuita: " + my_int.ToString());


	}



	
	// Update is called once per frame
	void Update () {
		
		RaycastHit hit = new RaycastHit ();
		Ray ray = new Ray ();
		ray = Camera.main.ViewportPointToRay (new Vector3 (0.5f, 0.5f, 1.0f));

		if (Physics.Raycast (ray, out hit)) {

			 
			if (hit.transform.name == "Cube") {
				if (interval > 0) {

					interval -= Time.deltaTime;
					Debug.Log ("Time cub");
				} else {
					
					Application.LoadLevel (1);
				}
			
			} 



			if (hit.transform.name == "Capsule") {
				if (interval > 0) {

					interval -= Time.deltaTime;
					Debug.Log ("Time caps");
				} else {

					Application.Quit ();
				}

			} 
		} else {
			interval = 1; Debug.Log ("Else Caps");
		}


	}		
}

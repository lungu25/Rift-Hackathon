using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trigger_Scene : MonoBehaviour 
{
	[SerializeField] private string loadLevel;
	void OntriggerEnter(Collider other )
	{
		if (other.CompareTag ("Player")) {
			SceneManager.LoadScene(loadLevel);
		}
	}

}


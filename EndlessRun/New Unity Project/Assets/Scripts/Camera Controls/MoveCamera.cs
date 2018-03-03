using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class MoveCamera : MonoBehaviour {

	public float speed = 5.0f;
	public float LRspeed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		CharacterController controller = GetComponent<CharacterController>();
		Vector3 forward = new Vector3 (0, 0, 0);
		Debug.Log("my vector forward " + this.gameObject.transform.GetChild(0).forward);

		if (Vector3.Angle (this.gameObject.transform.GetChild (0).forward, Vector3.forward) < 90) {
			Debug.Log ("turn");
			forward = transform.TransformDirection (Vector3.forward);
		} else {



			forward = Vector3.forward;
		}

		controller.SimpleMove(forward * speed);
	}
	void OnCollisionEnter(Collision other)
	{
		if (other.collider.CompareTag("Death"))
			Respawn();
	}

	void Respawn(){
		transform.position = Vector3.zero;
	}

}



//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//
//public class ButtonMove : MonoBehaviour {
//	[SerializeField]
//	private GameObject start_button;
//	[SerializeField]
//	private GameObject controller;
//
//	float new_velocity;
//	private Coroutine cr ;
//
//	void Start () {
//		new_velocity = controller.gameObject.GetComponent<MoveLookTo> ().velocity;
//		StartCoroutine (velocityRoutine ());	
//	}
//
//	private IEnumerator velocityRoutine()
//	{
//		while (true) {
//			Ray ray = new Ray ();
//			ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 1.0f));
//			RaycastHit hit = new RaycastHit();
//
//			if (Physics.Raycast (ray, out hit, 100)) {
//				Debug.Log ("hop");
//				if (hit.collider.gameObject.tag == "Stop") {
//					controller.gameObject.GetComponent<MoveLookTo> ().velocity = 0;
//				}
//				if (hit.collider.gameObject.tag == "Start") {
//					controller.gameObject.GetComponent<MoveLookTo> ().velocity = new_velocity;
//				}
//			}
//			yield return new WaitForSeconds(1);
//
//		}
//		cr = null;
//	}
//}


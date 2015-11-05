using UnityEngine;
using System.Collections;

public class CubeColision : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	}
	
	void OnTriggerEnter(Collider collision) {
		if (collision.gameObject.name.Contains ("Capsule")) {
			Debug.Log (collision.gameObject.name);
			Destroy (collision.gameObject);
		}
	}

	void OnCollisionExit(Collision collisionInfo) {
		print("No longer in contact with " + collisionInfo.transform.name);
		if (collisionInfo.gameObject.name.Equals ("Plane"))
			print ("Peta Bola");
		//Imprimir por pantalla que se ha finalizado la partida
		else
			Destroy (collisionInfo.gameObject);
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.name.Contains ("Frontera")) {
			if(Application.loadedLevelName.Equals ("nivel1")) Application.LoadLevel ("nivel2");
			if(Application.loadedLevelName.Equals ("nivel2")) Application.LoadLevel ("nivel3");
			if(Application.loadedLevelName.Equals ("nivel3")) Application.LoadLevel ("fin");

			Debug.Log ("Cargando nivel");
		}

		if (collision.gameObject.name.Contains ("Muerte")) {
			Application.LoadLevel (Application.loadedLevelName);
		}
	}
	
}


using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Puntuaciones : MonoBehaviour {
	private Text textMesh;
	private int nCapsulas;
	private int puntuacion;

	// Use this for initialization
	void Start () {
		textMesh = gameObject.GetComponent<Text> ();
		nCapsulas = GameObject.FindGameObjectsWithTag ("Capsule").Length;
	}
	
	// Update is called once per frame
	void Update () {
		float tiempo = Time.realtimeSinceStartup;
		int puntCapsulas = (nCapsulas - GameObject.FindGameObjectsWithTag ("Capsule").Length) * 100;
		textMesh.text = "" + puntuacion;

		if (tiempo <= 10)
			puntuacion = 1000 + puntCapsulas;
		else if (tiempo > 10 && tiempo <= 12)
			puntuacion = 500 + puntCapsulas;
		else
			puntuacion = 0 + puntCapsulas;

	}
}

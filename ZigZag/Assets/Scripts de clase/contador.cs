using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class contador : MonoBehaviour {
	private int nCapsulas;
	static float icontador = 0;
	private static float contadorLvl1 = 0;
	private static float contadorLvl2 = 0;
	private static float contadorlvl3 = 0;
	Text text;

	// Use this for initialization
	void Start () {
		nCapsulas = GameObject.FindGameObjectsWithTag ("Capsule").Length;
	}
	
	// Update is called once per frame
	void Update () {
		float tiempo = Time.realtimeSinceStartup;//Tiempo que lleva la app encendida
		int puntCapsulas = (nCapsulas - GameObject.FindGameObjectsWithTag ("Capsule").Length) * 100;//Capsulas obtenidas
		switch (Application.loadedLevelName) {
		case "nivel1":
			contadorLvl1 = puntCapsulas;
			break;
		case "nivel2":
			contadorLvl2 = puntCapsulas;
			break;
		case "nivel3":
			contadorlvl3 = puntCapsulas;
			break;
		}
		if(!Application.loadedLevelName.Equals("fin"))
			icontador = tiempo * 10 + contadorLvl1 + contadorLvl2 + contadorlvl3;
		text = GetComponent <Text> ();
		text.text = "" + icontador;
	}
}
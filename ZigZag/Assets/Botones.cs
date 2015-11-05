using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Botones : MonoBehaviour {
	
	public void GameStart () {
		Application.LoadLevel ("nivel1");
	}

	public void Clasificacion(){
		Application.LoadLevel ("clasificacion");
	}

	public void EndGame () {
		Application.Quit ();
	}

	public void GuardarPuntuacion(Text puntuacion){
		List<float> puntuaciones = new List<float>();
		for (int i = 1; i<6; i++)
			if (PlayerPrefs.HasKey ("Puntuacion_Jugador_" + i)) {
				puntuaciones.Add (float.Parse (PlayerPrefs.GetString ("Puntuacion_Jugador_" + i)));
			}
				
		puntuaciones.Add (float.Parse (puntuacion.text));
		puntuaciones.Sort ();
		puntuaciones.Reverse ();
		Debug.Log (puntuaciones[0]);
		int n_elementos = puntuaciones.Count + 1;
		for (int i=1; i < 6 && i < n_elementos; i++) {
			//if(puntuaciones[i-1] > 0)
			Debug.Log ("Entra");
			PlayerPrefs.SetString ("Puntuacion_Jugador_" + i, puntuaciones [i - 1] + "");
		}
		PlayerPrefs.Save ();
		Application.LoadLevel ("menu");
	}

	public void Atras(){
		Application.LoadLevel ("menu");
	}

}

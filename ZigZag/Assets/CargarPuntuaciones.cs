using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CargarPuntuaciones : MonoBehaviour {
	// Use this for initialization
	public Text puntuacion1;
	public Text puntuacion2;
	public Text puntuacion3;
	public Text puntuacion4;
	public Text puntuacion5;
	void Start () {
		puntuacion1.text = PlayerPrefs.GetString ("Puntuacion_Jugador_1");
		puntuacion2.text = PlayerPrefs.GetString ("Puntuacion_Jugador_2");
		puntuacion3.text = PlayerPrefs.GetString ("Puntuacion_Jugador_3");
		puntuacion4.text = PlayerPrefs.GetString ("Puntuacion_Jugador_4");
		puntuacion5.text = PlayerPrefs.GetString ("Puntuacion_Jugador_5");
	}

}

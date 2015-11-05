using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	
	public GameObject bola;
	public Transform camara;
	
	// Use this for initialization
	void Start () {
		camara = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		camara.position = new Vector3 (bola.transform.position.x + 7f, bola.transform.position.y +7f, bola.transform.position.z);
		
	}
}
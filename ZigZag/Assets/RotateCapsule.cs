using UnityEngine;
using System.Collections;

public class RotateCapsule : MonoBehaviour {
	
	private Transform capsula;
	// Use this for initialization
	void Start () {
		capsula = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		capsula.Rotate(new Vector3(3,3,0));
	}
}

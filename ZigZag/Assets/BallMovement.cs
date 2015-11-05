using UnityEngine;
using System.Collections;

/*public class BallMovement : MonoBehaviour {

	public Rigidbody ball;
	private int pos;
	
	// Use this for initialization
	void Start () {
		ball = GetComponent<Rigidbody> ();
		pos = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp (KeyCode.Space) && pos == 0){
			pos = 1;
		}else if (Input.GetKeyUp (KeyCode.Space) && pos == 1) {
			pos = 2;
		} else if (Input.GetKeyUp (KeyCode.Space) && pos == 2)
			pos = 1;

		if (pos == 1)
			ball.transform.Translate (Vector3.left * 0.2f);
		else if (pos == 2)
			ball.transform.Translate (Vector3.back * 0.2f);


		
	}
}*/

using UnityEngine;
using System.Collections;

public class BallMovement : MonoBehaviour {
	
	public Rigidbody ball;
	private int pos;
	
	// Use this for initialization
	void Start () {
		ball = GetComponent<Rigidbody> ();
		pos = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0) {
			TouchPhase fase = Input.GetTouch(0).phase;
			if(fase.Equals(TouchPhase.Ended)){
				
				if(pos == 0) pos = 1;
				else if(pos == 1) pos = 2;
				else pos = 1;
			}
		} 
		if(Input.GetKeyUp (KeyCode.Space) && pos == 0){
			pos = 1;
		}else if (Input.GetKeyUp (KeyCode.Space) && pos == 1) {
			pos = 2;
		} else if (Input.GetKeyUp (KeyCode.Space) && pos == 2)
			pos = 1;
		if (pos == 1)
			ball.transform.Translate (Vector3.left * 0.1f);
		else if (pos == 2)
			ball.transform.Translate (Vector3.back * 0.1f);
	}
}
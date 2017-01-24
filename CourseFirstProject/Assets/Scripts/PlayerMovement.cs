using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float playerSpeed = 5.0f;
	public float rotationSpeed = 20.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update(){
		//Movement ();

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Rotate (new Vector3 (0, rotationSpeed, 0));
		}
	}

	void Movement () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			this.transform.Translate(new Vector3(0 , 0, playerSpeed * Time.deltaTime));
		}else if (Input.GetKey (KeyCode.DownArrow)) {			
			this.transform.Translate(new Vector3(0 , 0, - playerSpeed * Time.deltaTime));
		}	

		if (Input.GetKey (KeyCode.LeftArrow)) {			
			this.transform.Translate(new Vector3(playerSpeed * Time.deltaTime, 0 , 0));
		}else if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate(new Vector3(- playerSpeed * Time.deltaTime, 0 , 0));
		}

		if (Input.GetKey (KeyCode.W)) {			
			this.transform.Translate(new Vector3(0, playerSpeed * Time.deltaTime, 0));
		}else if (Input.GetKey (KeyCode.S)) {
			this.transform.Translate(new Vector3(0, -playerSpeed * Time.deltaTime, 0));
		}
	}
}

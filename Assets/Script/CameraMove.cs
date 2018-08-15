using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

	public static float offSetX;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (CharScript.instance != null) {
			MoveTheCamera ();
		}
		
	}

	void MoveTheCamera(){
		Vector3 temp = transform.position;
		temp.x = CharScript.instance.GetPositionX()+offSetX;
		transform.position = temp; 
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour {

	private GameObject[] bgs;
	private GameObject[] gs;

	private float Lbgx;
	private float Lgx;

	void Awake(){
		bgs = GameObject.FindGameObjectsWithTag ("Background");	
		gs = GameObject.FindGameObjectsWithTag ("Ground");	

		Lbgx = bgs [0].transform.position.x;
		Lgx = gs [0].transform.position.x;

		for (int i = 0; i < bgs.Length; i++)
			if (Lbgx < bgs [i].transform.position.x) {
				Lbgx = bgs [i].transform.position.x;
			}

		for (int i = 0; i < gs.Length; i++) {
			if (Lgx < gs [i].transform.position.x) {
				Lgx = gs [i].transform.position.x;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D target){
		
		if (target.tag == "Background") {
			Debug.Log ("Background");
			Vector3 temp = target.transform.position;
			//float Width = ((BoxCollider2D)target).size.x;
			//temp.x = Lbgx + Width;
			temp.x = Lgx + 55f;
			Debug.Log (temp.x);
			target.transform.position = temp;
			Lbgx = temp.x;
		}
		else if (target.tag == "Ground") {
			
			Vector3 temp = target.transform.position;
			//float Width = ((BoxCollider2D)target).size.x;
			float Width = ((BoxCollider2D)target).bounds.min.x;
			Debug.Log (Width);
			float WidthMax = ((BoxCollider2D)target).bounds.max.x;
			Debug.Log (WidthMax);
			//temp.x = Lgx + Width;
			temp.x = Lgx + 55f;
			Debug.Log (temp.x);
			target.transform.position = temp;
			Lgx = temp.x;
		}
	}
}

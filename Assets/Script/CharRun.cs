using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CharRun : MonoBehaviour {

	private float fSpeed=3f;


	void Start () {
		
		/*GameObject Char = (GameObject)Instantiate(Resources.Load("Prefabs/"+"Char"));
		Button buttonCtrl = Char.GetComponent<Button>();
		buttonCtrl.onClick.AddListener(() => JumpTheChar());*/
	}
	
	void FixedUpdate () {
		if (CharScript.instance.run) {
			Vector3 temp = transform.position;
			temp.x += fSpeed * Time.deltaTime;
			transform.position = temp;
		}
	}

	public void JumpTheChar(){		
		CharScript.instance.run = false;
		CharScript.instance.idle = false;
		CharScript.instance.jump = true;
		Debug.Log ("Jump");
	}
}

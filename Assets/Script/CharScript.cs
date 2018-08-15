using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharScript : MonoBehaviour {

	public static CharScript instance;

	[SerializeField]
	private Animator Anim;
	public bool run=false;
	public bool idle=true;
	public bool jump=false;


	void Awake(){
		if (instance == null)
			instance = this;
		SetCameraX ();
	}

	void Start () {
		
	}
	
	void FixedUpdate () {
		if (run) {
			Anim.SetTrigger ("run");
			Anim.ResetTrigger("idle");
			Anim.ResetTrigger ("jump");
		} else
			if(idle){
			Anim.ResetTrigger ("run");
			Anim.SetTrigger("idle");
			Anim.ResetTrigger ("jump");
			}else
				if(jump){
					Anim.ResetTrigger ("run");
					Anim.ResetTrigger("idle");
					Anim.SetTrigger ("jump");
				}
	}

	public void RunTheChar(){		
		run = true;
		idle = false;
		jump = false;
	}

	public void IdleTheChar(){		
		run = false;
		idle = true;
		jump = false;
	}

	public void JumpTheChar(){		
		run = false;
		idle = false;
		jump = true;
		Debug.Log ("Jump");
	}

	public float GetPositionX(){
		return transform.position.x;
	}

	void SetCameraX(){
		CameraMove.offSetX = (Camera.main.transform.position.x - transform.position.x) - 1f;
	}
}

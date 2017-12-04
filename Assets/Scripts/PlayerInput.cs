using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : PlayerController {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("right")) {
			MoveButtonRight();
		}
		if (Input.GetKey ("left")) {
			MoveButtonLeft();
		}
		if (Input.GetKey ("up")) {
			MoveButtonUp();
		}
		if (Input.GetKey ("down")) {
			MoveButtonDown();
		}



		if (Input.GetMouseButtonDown (0)) {
			MoveTap ();
		}
		if(NowMoving) {
			AutoMove ();
		}


	}



	public override void MoveButtonRight(){
		base.MoveButtonRight ();
	}
	public override void MoveButtonLeft(){
		base.MoveButtonLeft ();
	}
	public override void MoveButtonUp(){
		base.MoveButtonUp ();
	}
	public override void MoveButtonDown(){
		base.MoveButtonDown ();
	}
	public override void MoveTap(){
		base.MoveTap ();
	}
	public override void AutoMove(){
		base.AutoMove ();
	}
		
}

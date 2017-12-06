using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : PlayerController {
	bool isPlayable = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		if (!isPlayable)
//			return;



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
			if (isPlayable) {
				StartCoroutine (AutoMove ());
				isPlayable = false;
			}
		}
		if (DoneMove ()) {
			isPlayable = true;
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
	public override IEnumerator AutoMove(){
	yield return StartCoroutine(base.AutoMove ());
	}
	public override bool DoneMove(){
		return base.DoneMove ();
	}
		
}

//参考にしたサイト
///https://gamedev.stackexchange.com/questions/120055/overriding-coroutine-doesnt-execute-base-code
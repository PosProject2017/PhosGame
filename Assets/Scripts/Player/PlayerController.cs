using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	//参考にしたサイト
	//https://gist.github.com/Buravo46/7728812
	//https://ja.stackoverflow.com/questions/3013/unity%E3%81%A72d%E3%82%AD%E3%83%A3%E3%83%A9%E3%82%AF%E3%82%BF%E3%82%92%E3%82%AF%E3%83%AA%E3%83%83%E3%82%AF%E3%81%97%E3%81%9F%E5%A0%B4%E6%89%80%E3%81%B8%E7%A7%BB%E5%8B%95-%E5%AF%BE%E5%BF%9C%E3%81%97%E3%81%9Fsprite%E3%82%92%E8%A1%A8%E7%A4%BA%E3%81%95%E3%81%9B%E3%82%8B%E3%81%AB%E3%81%AF
	//http://blog.kazumalab.com/entry/2016/07/14/155730

	public float Speed = 0.05f;//移動速度
	private float Step;
	public Vector3 ClickPosition;//クリックした位置
	public bool NowMoving = false;

	// Use this for initialization
	void Start () {
	}


	//ボタン操作
	/// <summary>
	/// Moves the right.
	/// </summary>
	public virtual void MoveButtonRight(){
		Vector2 Position = transform.position;
		Position.x += Speed;
		transform.position = Position;
	}

	public virtual void MoveButtonLeft(){
		Vector2 Position = transform.position;
		Position.x -= Speed;
		transform.position = Position;
	}
	public virtual void MoveButtonUp(){
		Vector2 Position = transform.position;
		Position.y += Speed;
		transform.position = Position;
	}
	public virtual void MoveButtonDown(){
		Vector2 Position = transform.position;
		Position.y -= Speed;
		transform.position = Position;
	}

	//タップ・クリック操作
	public virtual void MoveTap(){
		ClickPosition = Input.mousePosition;
		ClickPosition.z += 10;
		ClickPosition = Camera.main.ScreenToWorldPoint (ClickPosition);//カメラ座標を世界座標に
		NowMoving = true;
	}

	public virtual void AutoMove(){
		if (transform.position == new Vector3 (ClickPosition.x, ClickPosition.y, 0)) {
			NowMoving = false;
		}
		float Step = 5 * Time.deltaTime;
		transform.position = Vector2.MoveTowards (transform.position, new Vector2 (ClickPosition.x, ClickPosition.y), Step);
	}
}

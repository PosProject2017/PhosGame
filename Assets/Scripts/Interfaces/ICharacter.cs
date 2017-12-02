using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter {

    /// <summary>
    /// キャラクターのステータスを取得する
    /// </summary>
    void LoadStatus();

    /// <summary>
    /// ジャンプする
    /// </summary>
    void Jump();

    /// <summary>
    /// 右に動く
    /// </summary>
    void moveRight();

    /// <summary>
    /// 左に動く
    /// </summary>
    void moveLeft();





}

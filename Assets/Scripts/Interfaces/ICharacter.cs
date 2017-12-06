using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICharacter {

    /// <summary>
    /// キャラクターのステータスを取得する
    /// </summary>
    CharacterStatus LoadStatus( CharacterStatus targetStust );


}

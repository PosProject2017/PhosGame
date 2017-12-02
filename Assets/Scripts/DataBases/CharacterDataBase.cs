using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDataBase : MonoBehaviour {

    /// <summary>
    /// キャラクター登録
    /// </summary>
    public enum CharacterIdentifier {
        NONE
    }

    /// <summary>
    /// キャラクターのステータスを取得
    /// </summary>
    /// <param name="characterId"></param>
    /// <returns></returns>
    public CharacterStuts getCharactetStatus( CharacterIdentifier characterId ) {
        CharacterStuts characterStuts = new CharacterStuts();
        characterStuts.setStuts( 0, 0, 0, 0 );

        switch( characterId ) {

        }

        return characterStuts;
    }
}

public class CharacterStuts {
    public float HP;
    public float Offence;
    public float Deffence;
    public float Speed;

    public void setStuts( float hp, float offence, float deffence, float speed) {
        HP = hp;
        Offence = offence;
        Deffence = deffence;
        Speed = speed;

    }
}

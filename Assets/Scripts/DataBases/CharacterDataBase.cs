using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CharacterDataBase{

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
    public CharacterStatus getCharacterStatus( CharacterStatus status ) {
        CharacterStatus characterStatus = new CharacterStatus();

        switch( status.type ) {

        }

        return characterStatus;
    }
}



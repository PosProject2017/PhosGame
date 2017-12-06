using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour,ICharacter {

    [SerializeField]
    private CharacterDataBase.CharacterIdentifier character;
    private CharacterStatus characterStatus;

    public CharacterStatus LoadStatus( CharacterStatus targetStusts ) {
        CharacterStatus status = new CharacterStatus();
        CharacterDataBase characterDataBase = new CharacterDataBase();
        if( targetStusts.type == CharacterDataBase.CharacterIdentifier.NONE ) {
            targetStusts.setType( character );
        }
        status = characterDataBase.getCharacterStatus( targetStusts );
        return status;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageAdjuster : MonoBehaviour {

    StageData stageData = new StageData();

	void Start(){
		
	}

    public Vector3 getStagePosition(Vector2 stageId ){
        float stageLength = stageData.stageLengthWidth;
		float stageHeight = stageData.stageLengthHeight;

        float centerPosX = stageId.x * (stageLength - 1) + stageLength / 2;
        float centerPosY = stageId.y * (stageHeight - 1) + stageHeight / 2;

        return new Vector3(centerPosX, 0, centerPosY);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Linq;


public class StageManager : MonoBehaviour
{
    //ステージの情報
    [SerializeField] private Vector2 stageId;
    [SerializeField] private bool isMainStage;

    //ロードするシーン
    [System.SerializableAttribute]
    public struct isSubStageRow
    {
        public bool column0;
        public bool column1;
        public bool column2;
    }
    [SerializeField] private isSubStageRow[] isSubStageMatrix = new isSubStageRow[3];
	
    void Start()
    {
        // ステージの位置を調整
        StageAdjuster stageAdjuster = new StageAdjuster();
        transform.position = stageAdjuster.getStagePosition(stageId);

        // 他のステージを展開
        LoadAroundScene();

    }

	//####################################################################################################
	/// <summary>
	/// 周辺のステージをロードする
	/// </summary>
	//####################################################################################################
    void LoadAroundScene()
    {
        if (!isMainStage)
        {
            return;
        }

        for (int i = 0; i < 3; i++)
        {
            if (isSubStageMatrix[i].column0)
            {
                SceneManager.LoadScene("Stage" + (stageId.x + (1 - i)) + "_" + (stageId.y + 1), LoadSceneMode.Additive);
            }
			 if (isSubStageMatrix[i].column1 && i!=1)
            {
				SceneManager.LoadScene("Stage" + (stageId.x + (1 - i)) + "_" + (stageId.y), LoadSceneMode.Additive) ;
            }
			 if (isSubStageMatrix[i].column2)
            {
				SceneManager.LoadScene("Stage" + (stageId.x + (1 - i)) + "_" + (stageId.y - 1), LoadSceneMode.Additive) ;
            }
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class DebugStageTransrater : MonoBehaviour
{

    public void SceneJump(Text destination)
    {
        string nextStageName = "Stage" + destination.text;

		//シーンが存在するかを確認
        /*
		if(!ContainsScene(nextStageName)){
            Debug.Log("シーン["+ nextStageName +"]は存在しません");
            return;
        }
		*/

        SceneManager.LoadScene(nextStageName);


    }

    bool ContainsScene(string sceneName)
    {
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Debug.Log(SceneManager.GetSceneAt(i).name);
            if (SceneManager.GetSceneAt(i).name == sceneName)
            {
                return true;
            }
        }
        return false;
    }
}

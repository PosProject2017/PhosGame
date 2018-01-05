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
        SceneManager.LoadScene(nextStageName);
    }
}

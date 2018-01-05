using UnityEngine;
using UnityEditor;
using System.Collections;

public class GameStarter : MonoBehaviour {

    [MenuItem("Tools/PlayGame %0")]
    public static void PlayFromPrelaunchScene()
    {
    
        // プレイ中ならば停止する
        if (EditorApplication.isPlaying == true) {
            EditorApplication.isPlaying = false;
            return;
        }
        
        // 再生したいシーンの読み込み->再生
        EditorApplication.SaveCurrentSceneIfUserWantsTo ();
        EditorApplication.OpenScene ("Assets/Scenes/DebugBoot.unity");
        EditorApplication.isPlaying = true;
    }
}

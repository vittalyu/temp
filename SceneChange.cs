using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorSceneChange : MonoBehaviour
{
    public string sceneName;

    void ontrOnTriggerEnter(Collider other)
    {
        EditorSceneManager.LoadScene(sceneName);
    }
}
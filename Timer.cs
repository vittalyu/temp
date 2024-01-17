using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    public int minutes = 3;
    public float secundes = 59.0f;
    void Update()
    {
        secundes -= Time.deltaTime;
        timer.text = minutes + ":" + secundes;
        if (secundes <= 0)
        {
            if (minutes > 0)
            {
                minutes = 1;
                secundes = 59.0f;
            }
            else
            {
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }
        }
    }
}

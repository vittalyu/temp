using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Temperature : MonoBehaviour
{
    public Health health;
    private float currentTemp = 36.6f;
    public float maxTemp = 36.6f;
    public float minTemp = 34.4f;
    public TextMeshProUGUI tempText;
    public int damage = 2;
    public float delay = 2;
    public float freezeSpeed = 0.1f;
    public float timer = 1;
    // Update is called once per frame
    void Update()
    {
        currentTemp -= freezeSpeed * Time.deltaTime;
        if (currentTemp <= minTemp)
        {
            if (timer <= 0)
            {
                health.TakeDamage(damage);
                timer += delay;
            }
            else
            {
                timer -= Time.deltaTime;
            }
        }
    }
}
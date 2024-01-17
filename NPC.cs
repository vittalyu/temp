using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    int health = 5;
    //Óðîâåíü
    int level = 1;
    //Ñêîðîñòü
    float speed = 1.2f;
    Vector3 new_pos;
    // Start is called before the first frame update
    void Start()
    {
        health += level;
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        new_pos = this.transform.position;
        new_pos.z += speed * Time.deltaTime;
        this.transform.position = new_pos;
    }
}

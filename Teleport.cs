using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportPoint;
    private void OnTriggerEnter(Collider other)
    void Start()
    {
        other.transform.position = teleportPoint.position;
    }

}
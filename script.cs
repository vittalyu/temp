using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    [SerializeField] private int health = 5;
    int movementSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 New1 = transform.position;
        New1.z += movementSpeed * Time.deltaTime;

        transform.position  = New1;

        //output to log the position change
        Debug.Log(transform.position);
    }
}
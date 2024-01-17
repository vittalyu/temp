using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    //���������� ������� ������ ��������
    public float speed = 10;


    private void Start()
    {
        //����������� ������� ����� 3 ������� 
        Destroy(gameObject, 2);
    }
    // Update is called once per frame
    void Update()
    { 
        //�������� ������� �����
        transform.position +=transform.forward * speed * Time.deltaTime;
    }
    //��������� ������������
    private void OnTriggerEnter(Collider other)
    {
        //����������� ����� �������
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}

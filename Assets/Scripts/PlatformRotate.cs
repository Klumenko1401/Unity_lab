using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random; //��������� ����� ����
using System;

public class PlatformRotate : UnityEngine.MonoBehaviour
{
    public Vector3 rotateChange;
    // ���������� �������� ��� ����������� ����������� �������� �� ����
    public float maxRotateX = 10f;
    public float maxRotateY = 10f;
    public float maxRotateZ = 10f;

    // Start is called before the first frame update
    void Start()
    {
        // �������� �������� �������� ��� ����������� ���������
        rotateChange = new Vector3(Random.Range(-maxRotateX, maxRotateX), Random.Range(-maxRotateY, maxRotateY), Random.Range(-maxRotateZ, maxRotateZ));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotateChange * Time.deltaTime); // ������� �� Time.deltaTime ��� ���������� ������ �� ����� ��������
    }
}

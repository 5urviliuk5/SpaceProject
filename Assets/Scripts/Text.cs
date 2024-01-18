using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    private float speed = 1.2f;

    void Update()
    {
        Vector3 temp = transform.position;
        temp.y += speed * Time.deltaTime;
        transform.position = temp;
    }
}
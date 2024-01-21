using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float speedIncreaseRate = 0.15f;

    void Update()
    {
        Vector3 temp = transform.position;
        temp.x -= speed * Time.deltaTime;
        transform.position = temp;

        transform.Translate(Vector2.left * speed * Time.deltaTime);
        speed += speedIncreaseRate * Time.deltaTime;
    }
}

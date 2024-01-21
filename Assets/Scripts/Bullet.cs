using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 2f);
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 temp = transform.position;
        temp.x += speed * Time.deltaTime;
        transform.position = temp;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Kill")
        {
            float distance = Vector2.Distance(transform.position, other.transform.position);
            float hitRange = 1.0f;

            if (distance < hitRange)
            {
                Destroy(gameObject); // bullet
                Destroy(other.gameObject); // enemy
            }
        }
    }
}

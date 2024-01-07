using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 8f;
    public float maxY;
    public float minY;

    public GameObject button;
    public Space space;

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetAxisRaw("Vertical") > 0f)
        {
            Vector3 temp = transform.position;
            temp.y += speed * Time.deltaTime;

            if (temp.y > maxY)
            {
                temp.y = maxY;
            }

            transform.position = temp;
        }
        else if (Input.GetAxisRaw("Vertical") < 0f)
        {
            Vector3 temp = transform.position;
            temp.y -= speed * Time.deltaTime;

            if (temp.y < minY)
            {
                temp.y = minY;
            }

            transform.position = temp;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);

        space.speed = 0f;

        button.SetActive(true);
    }
}

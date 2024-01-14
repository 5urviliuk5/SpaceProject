using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 8f;
    public float maxY;
    public float minY;
    public GameObject bullet;
    public Transform shootPoint;
    public GameObject button;
    public Space space;

    // RANDOM ENEMY POSITIONS
    // DIFFICULTIES
    // INTRO
    // FINAL

    void Update()
    {
        MovePlayer();
        Attack();
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

    void OnTriggerEnter2D(Collider2D other) // kills player
    {
        if (other.tag == "Kill")
        {
            space.speed = 0f;
            button.SetActive(true);
        }
    }

    void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, shootPoint.position, shootPoint.rotation); // galima Quaternion.identity vietoj shootPoint.rotation
        }
    }
}
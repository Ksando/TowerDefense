using UnityEngine;
using System.Collections;

public class CharacterMove : MonoBehaviour
{
    float dirX, dirY;
    public float speed;
    Rigidbody2D rb;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        dirX = Input.GetAxis("Horizontal");

        dirY = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX * speed, dirY * speed);
    }
}
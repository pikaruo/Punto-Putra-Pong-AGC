using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    [SerializeField] int speed;
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;
    private Rigidbody2D rb;
    private Transform tf;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
    }

    void Update()
    {
        // move object
        MoveObject(GetInput());
        if (tf.position.y > 3.75f)
        {
            tf.position = new Vector2(transform.position.x, 3.75f);
        }
        else if (tf.position.y < -3.75f)
        {
            tf.position = new Vector2(transform.position.x, -3.75f);
        }
    }

    // func get input
    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }

        if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    // func move move paddle
    private void MoveObject(Vector2 movement)
    {
        // Debug.Log("Test : " + movement);
        rb.velocity = movement;
    }
}

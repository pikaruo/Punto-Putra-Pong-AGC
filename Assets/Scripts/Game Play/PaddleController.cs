using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{

    [SerializeField] float speed;
    [SerializeField] KeyCode upKey;
    [SerializeField] KeyCode downKey;
    [SerializeField] GameObject leftPaddle;
    [SerializeField] GameObject rightPaddle;
    private Rigidbody2D rb;
    private Transform tf;

    [SerializeField] float timeOut = 5;
    [SerializeField] float timer = 0;

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

        if (timer < timeOut)
        {
            timer += Time.deltaTime;
            return;
        }
        else
        {
            // kembalikan semua seperti semula jika sudah 5 detik
            leftPaddle.transform.localScale = new Vector2(0.3f, 2);
            rightPaddle.transform.localScale = new Vector2(0.3f, 2);
            speed = 8;
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

    // mengubah ukurang paddle kiri
    public void ActivateLeftPaddleScale(float magnitude)
    {
        leftPaddle.transform.localScale = new Vector2(0.3f, 2 * magnitude);
        timer = 0;
    }

    // mengubah ukurang paddle kanan
    public void ActivateRigtPaddleScale(float magnitude)
    {
        rightPaddle.transform.localScale = new Vector2(0.3f, 2 * magnitude);
        timer = 0;
    }

    // mengubah kecepatan paddle
    public void ActivatePaddleSpeed(float magnitude)
    {
        speed *= magnitude;
        timer = 0;
    }

}

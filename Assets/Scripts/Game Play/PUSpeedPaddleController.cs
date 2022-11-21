using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedPaddleController : MonoBehaviour
{
    public SpeedUpManager manager;
    public Collider2D ball;
    public float magnitude;
    public GameObject leftPaddle, rightPaddle;

    // mencari lokasi bola terakhir kali
    public Rigidbody2D ballLastLocation;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball && ballLastLocation.velocity.x > 0)
        {
            leftPaddle.GetComponent<PaddleController>().ActivatePaddleSpeed(magnitude);
            Destroy(gameObject);
            manager.RemovePowerUp(gameObject);
        }
        else if (collision == ball && ballLastLocation.velocity.x < 0)
        {
            rightPaddle.GetComponent<PaddleController>().ActivatePaddleSpeed(magnitude);
            Destroy(gameObject);
            manager.RemovePowerUp(gameObject);
        }
    }
}

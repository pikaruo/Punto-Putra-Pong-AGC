using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSaclePaddleController : MonoBehaviour
{
    public SpeedUpManager manager;
    public Collider2D ball;
    public GameObject leftPaddle, rightPaddle;
    private Rigidbody2D rig;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == ball)
        {
            leftPaddle.transform.localScale = new Vector2(0.3f, 4);
            Destroy(gameObject);
            manager.RemovePowerUp(gameObject);
            // Debug.Log("Negatif : " + rig.velocity.x);
        }
    }
}

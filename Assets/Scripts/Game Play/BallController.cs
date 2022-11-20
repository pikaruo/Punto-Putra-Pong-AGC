using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    [SerializeField] Vector2 speed;
    [SerializeField] Vector2 resetPosition;
    public Rigidbody2D rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        // ball move
        rig.velocity = speed;
    }

    private void Update()
    {
        arahBola();
    }

    // reset ball pos
    public void ResetBall()
    {
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 2);
        rig.velocity = speed;
    }

    public void ActivatePUSpeedUp(float magnitude)
    {
        rig.velocity *= magnitude;
    }

    public GameObject leftPaddle, rightPaddle;
    public void arahBola()
    {
        if (rig.velocity.x < 0)
        {
            Debug.Log("Negatif : " + rig.velocity.x);
        }
        else if (rig.velocity.x > 0)
        {
            Debug.Log("Positif : " + rig.velocity.x);
        }
    }
}

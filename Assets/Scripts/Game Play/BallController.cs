using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{

    [SerializeField] Vector2 speed;
    [SerializeField] Vector2 resetPosition;
    public Rigidbody2D rig;

    Vector2 speedAwal;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        // ball move
        rig.velocity = speed;
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

}

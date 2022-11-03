using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] Text leftScore;
    [SerializeField] Text rightScore;
    [SerializeField] ScoreManager manager;

    private void Update()
    {
        leftScore.text = manager.leftScore.ToString();
        rightScore.text = manager.rightScore.ToString();
    }
}

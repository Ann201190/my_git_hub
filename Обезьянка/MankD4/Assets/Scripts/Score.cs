using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int scoreAmount;
    public static int scoreAmount1;
    public static int scoreAmount2;
    Text scoreText;
    void Start()
    {
        scoreText = GetComponent <Text> ();
        scoreAmount = 0;
        scoreAmount1 = 0;
        scoreAmount2 = 0;
    }

    void Update()
    {
        int sum = scoreAmount + scoreAmount1 + scoreAmount2;

        scoreText.text = sum.ToString();       
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text ScoreText;
    public static int score = 0;

    // Update is called once per frame
    void Update()
    {
        // Display score
        ScoreText.text = "Score: " + score.ToString();
    }
}

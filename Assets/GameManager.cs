using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static int score = 0;
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = "Coins: " + score;
    }
}
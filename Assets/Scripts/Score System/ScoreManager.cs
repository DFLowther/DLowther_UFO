using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public GameObject winText;

    public void AddPoints(int _amount)
    {
        score += _amount;

        scoreText.text = "Gold: " + score;

        if (score >+ 8)
        {
            winText.SetActive(true);
        }
    }
}

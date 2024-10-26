using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public TMP_Text pointsText;  // Use TMP_Text for TextMeshPro
    private int score = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        pointsText.text = "Points: " + score.ToString();
    }

    public void AddPoints(int points)
    {
        score += points;
        pointsText.text = "Points: " + score.ToString();
    }
}

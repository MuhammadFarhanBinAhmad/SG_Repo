using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int _score;
    public TextMeshProUGUI _text;
    public void AddScore()
    {
        _score++;
        _text.text = "Score: " + _score.ToString();
    }
}

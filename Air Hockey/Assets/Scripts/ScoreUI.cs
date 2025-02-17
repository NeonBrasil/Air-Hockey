using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Refer�ncia ao texto do placar
    public ScoreManager scoreManager; // Refer�ncia ao sistema de pontos

    void Update()
    {
        // Atualiza a UI do placar constantemente
        scoreText.text = scoreManager.playerScore + " - " + scoreManager.aiScore;
    }
}

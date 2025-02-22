using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // ReferÍncia ao texto do placar
    public ScoreManager scoreManager; // ReferÍncia ao sistema de pontos

    void Update()
    {
        // Atualiza a UI do placar constantemente
        scoreText.text = scoreManager.playerScore + " - " + scoreManager.aiScore;
    }
}

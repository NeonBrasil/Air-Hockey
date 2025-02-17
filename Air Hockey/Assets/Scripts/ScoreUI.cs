using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Referência ao texto do placar
    public ScoreManager scoreManager; // Referência ao sistema de pontos

    void Update()
    {
        // Atualiza a UI do placar constantemente
        scoreText.text = scoreManager.playerScore + " - " + scoreManager.aiScore;
    }
}

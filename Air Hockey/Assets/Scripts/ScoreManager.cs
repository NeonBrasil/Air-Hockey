using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public int playerScore = 0;
    public int aiScore = 0;

    public void AddPointToPlayer()
    {
        playerScore++;
        Debug.Log("Jogador marcou! Placar: " + playerScore + " - " + aiScore);
    }

    public void AddPointToAI()
    {
        aiScore++;
        Debug.Log("IA marcou! Placar: " + playerScore + " - " + aiScore);
    }
}

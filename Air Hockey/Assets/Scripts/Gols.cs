using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Goal : MonoBehaviour
{
    public bool isPlayerGoal; // Se for o gol do player, o ponto vai para a IA
    public ScoreManager scoreManager; // Refer�ncia ao gerenciador de pontos
    public Transform puckStartPosition; // Local onde o disco ser� reposicionado

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Disco")) // Certifica-se de que o disco bateu no gol
        {
            if (scoreManager != null)
            {
                if (isPlayerGoal)
                    scoreManager.AddPointToAI(); // Gol no player = ponto para a IA
                else
                    scoreManager.AddPointToPlayer(); // Gol na IA = ponto para o jogador
            }

            // Reposiciona o disco no centro
            other.transform.position = puckStartPosition.position;
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null)
                rb.linearVelocity = Vector3.zero; // Para o movimento do disco
        }
    }
}

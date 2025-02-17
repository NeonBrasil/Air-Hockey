using UnityEngine;

public class AIController : MonoBehaviour
{
    public Transform puck; // Referência ao disco
    public float speed = 5f; // Velocidade da IA
    public Vector2 movementLimits = new Vector2(4f, 3f); // Limites do movimento

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Pega o Rigidbody do jogador
        rb.freezeRotation = true; // Evita rotação indesejada
    }

    void FixedUpdate()
    {
        MoveAI();
    }

    void MoveAI()
    {
        if (puck == null) return; // Se o disco não existir, não faz nada

        // Pega a posição do disco
        Vector3 targetPosition = new Vector3(puck.position.x, transform.position.y, puck.position.z);

        // Mantém a IA na metade superior da mesa
        targetPosition.z = Mathf.Clamp(targetPosition.z, 0.5f, movementLimits.y);

        // Move suavemente a IA em direção ao disco
        rb.MovePosition(Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime));
    }
}

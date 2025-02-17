using UnityEngine;

public class AIController : MonoBehaviour
{
    public Transform puck; // Refer�ncia ao disco
    public float speed = 5f; // Velocidade da IA
    public Vector2 movementLimits = new Vector2(4f, 3f); // Limites do movimento

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Pega o Rigidbody do jogador
        rb.freezeRotation = true; // Evita rota��o indesejada
    }

    void FixedUpdate()
    {
        MoveAI();
    }

    void MoveAI()
    {
        if (puck == null) return; // Se o disco n�o existir, n�o faz nada

        // Pega a posi��o do disco
        Vector3 targetPosition = new Vector3(puck.position.x, transform.position.y, puck.position.z);

        // Mant�m a IA na metade superior da mesa
        targetPosition.z = Mathf.Clamp(targetPosition.z, 0.5f, movementLimits.y);

        // Move suavemente a IA em dire��o ao disco
        rb.MovePosition(Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime));
    }
}

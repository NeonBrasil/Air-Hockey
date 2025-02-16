using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f; // Velocidade do jogador
    public Vector2 movementLimits = new Vector2(4f, 3f); // Limites do movimento

    private Rigidbody rb;
    private Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Pega o Rigidbody do jogador
        rb.freezeRotation = true; // Evita rota��o indesejada
        rb.collisionDetectionMode = CollisionDetectionMode.Continuous; // Evita atravessamento
        rb.interpolation = RigidbodyInterpolation.Interpolate; // Suaviza o movimento
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButton(0)) // S� move se o bot�o esquerdo estiver pressionado
        {
            MovePlayer();
        }
    }

    void MovePlayer()
    {
        // Pega a posi��o do mouse em rela��o � tela
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = Mathf.Abs(mainCamera.transform.position.y - transform.position.y); // Dist�ncia correta para convers�o

        // Converte a posi��o do mouse para o mundo 3D
        Vector3 worldPosition = mainCamera.ScreenToWorldPoint(mousePosition);

        // Limita o movimento dentro da �rea definida
        worldPosition.x = Mathf.Clamp(worldPosition.x, -movementLimits.x, movementLimits.x);
        worldPosition.z = Mathf.Clamp(worldPosition.z, -movementLimits.y, movementLimits.y);

        // Move usando Rigidbody respeitando colis�es
        Vector3 targetPosition = new Vector3(worldPosition.x, transform.position.y, worldPosition.z);
        Vector3 direction = (targetPosition - transform.position).normalized;

        rb.linearVelocity = direction * speed;
    }
}

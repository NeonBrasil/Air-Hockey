using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) // Verifica se a tecla "R" foi pressionada
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Recarrega a cena atual
        }
    }
}

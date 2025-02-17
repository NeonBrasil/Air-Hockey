using UnityEngine;

public class DiscoSound : MonoBehaviour
{
    public AudioSource audioSource; // Componente de áudio
    public AudioClip hitSound; // Som de impacto

    void Start()
    {
        if (audioSource == null)
            audioSource = GetComponent<AudioSource>(); // Pega o AudioSource do disco
    }

    void OnCollisionEnter(Collision collision)
    {
        // Verifica se existe um som configurado antes de tocar
        if (hitSound != null && audioSource != null)
        {
            audioSource.PlayOneShot(hitSound);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{
    public AudioClip sonidoInicio;

    private void Start()
    {
        // Asegúrate de tener un componente de Audio Source en el mismo GameObject
        AudioSource audioSource = GetComponent<AudioSource>();

        if (audioSource == null)
        {
            Debug.LogError("No se encontró un componente AudioSource en el GameObject.");
            return;
        }

        // Asigna el clip de audio al AudioSource
        audioSource.clip = sonidoInicio;

        // Reproduce el sonido
        audioSource.Play();
    }
}

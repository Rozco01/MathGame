using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del personaje
    private Rigidbody2D rb;
    private Animator anim;
    private Vector3 escalaOriginal;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

        // Guardar la escala original
        escalaOriginal = transform.localScale;
    }

    private void Update()
    {
        // Obtener la dirección de entrada horizontal
        float direccionHorizontal = Input.GetAxis("Horizontal");

        // Mover al personaje en la dirección horizontal
        Vector2 movimiento = new Vector2(direccionHorizontal * velocidad, rb.velocity.y);
        rb.velocity = movimiento;

        // Cambiar la orientación del personaje
        if (direccionHorizontal < 0)
        {
            transform.localScale = new Vector3(-Mathf.Abs(escalaOriginal.x), escalaOriginal.y, escalaOriginal.z);
        }
        else if (direccionHorizontal > 0)
        {
            transform.localScale = escalaOriginal; // Restaurar la escala original
        }

        // Cambiar las animaciones según la velocidad
        if (Mathf.Abs(rb.velocity.x) > 0.1f)
        {
            // Cambiar a la animación de caminar
            anim.SetBool("Caminando", true);
        }
        else
        {
            // Cambiar a la animación de estar quieto
            anim.SetBool("Caminando", false);
        }
    }  
}

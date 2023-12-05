using UnityEngine;

public class BasketBallAnimator : MonoBehaviour
{
    public Animator animator;
    private int contador = 0;

    public void CambiarEstadoAnimator()
    {
        // Incrementa el contador
        contador++;

        // Limita el contador a un máximo de 5
        contador = Mathf.Clamp(contador, 0, 5);

        // Genera el nombre del estado basado en el valor del contador
        string nombreEstado = "Balon" + contador;

        // Cambia al estado correspondiente
        animator.Play(nombreEstado);
    }
}

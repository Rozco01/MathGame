using System.Collections;
using UnityEngine;

public class AnimBolosController : MonoBehaviour
{
    public GameObject Bola1, Bola2, Bola3, Bola4;
    public int contador = 0;

    private void Start()
    {
        contador = 0;
    }

    public void OcultarBola()
    {
        contador++;

        StartCoroutine(DesaparecerBola(contador));
    }

    IEnumerator DesaparecerBola(int bolaNumero)
    {
        GameObject bola = null;

        // Asigna la bola correspondiente según el número
        switch (bolaNumero)
        {
            case 1:
                bola = Bola1;
                break;
            case 2:
                bola = Bola2;
                break;
            case 3:
                bola = Bola3;
                break;
            case 4:
                bola = Bola4;
                break;
            default:
                break;
        }

        // Si se encontró una bola, espera 2 segundos y luego la oculta
        if (bola != null)
        {
            yield return new WaitForSeconds(2f);

            bola.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosFinal : MonoBehaviour
{
    public TMPro.TextMeshProUGUI puntos;
    // Start is called before the first frame update
    void Start()
    {
        puntos.text = "Felicitaciones, has concluido el mundo final. Su puntuación final fue: " + PointsController.instance.currentPoints.ToString();
    }


}

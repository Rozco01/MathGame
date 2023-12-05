using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsUpdate : MonoBehaviour
{
    public TMPro.TextMeshProUGUI pointsText;
    private void Update()
    {
        pointsText.text = "Puntos: " + PointsController.instance.currentPoints.ToString();
    }
}

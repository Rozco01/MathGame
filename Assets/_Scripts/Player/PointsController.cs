using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsController : MonoBehaviour
{
    public static PointsController instance;
    public float currentPoints;
    public bool isDoor1 = true, isDoor2 = false,isDoor3 = false;
    public bool isMesage = false;

    private void Awake()
    {
        if (PointsController.instance == null)
        {
            PointsController.instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    public void AddPoints(float points)
    {
        currentPoints += points;
    }
    public void ChangeDoor2()
    {
        isDoor2 = true;
    }
    public void ChangeDoor3()
    {
        isDoor3 = true;
    }
}

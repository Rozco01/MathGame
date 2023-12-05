using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesaggeController : MonoBehaviour
{
    public GameObject Spawn;
    public GameObject mesagge;
    
    public bool isMesagge = false;
    
    private void Start() {
        if (PointsController.instance.isMesage == true)
        {
            mesagge.SetActive(false);
            Spawn.SetActive(true);
            
        }
    }
    public void HiddenMesagge()
    {
        mesagge.SetActive(false);
        Spawn.SetActive(true);
        PointsController.instance.isMesage = true;
        PointsController.instance.isDoor1 = true;  
    }
}

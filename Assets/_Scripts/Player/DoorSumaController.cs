using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSumaController : MonoBehaviour
{
    public TMPro.TextMeshProUGUI text;

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (PointsController.instance.isDoor1 == false)
            {
                text.text = "La puerta esta bloqueada";
                return;
            }
            else
            {
                text.text = "Presiona E para entrar";
                if (Input.GetKey(KeyCode.E))
                {
                    PointsController.instance.isDoor1 = false;
                    SceneManager.LoadScene("Basket");
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            text.text = "";
        }
    }
}

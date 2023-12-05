using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PizarraController : MonoBehaviour
{
    public GameObject BotonTirar;
    public GameObject pizarra;
    public GameObject pregunta1, pregunta2, pregunta3, pregunta4, pregunta5;
    public GameObject Correcto, Incorrecto;
    public Animator animacionBolos;
    public int contador = 0;
    public AudioClip Correct;
    public AudioClip Incorrect;

    [SerializeField] private bool isPressed;

    // Start is called before the first frame update
    void Start()
    {
        isPressed = false;
        contador = 0;
        pizarra.SetActive(false);
        pregunta1.SetActive(false);
        pregunta2.SetActive(false);
        pregunta3.SetActive(false);
        pregunta4.SetActive(false);
        pregunta5.SetActive(false);
        Correcto.SetActive(false);
        Incorrecto.SetActive(false);
    }

    private void Update()
    {
        if (isPressed == true)
        {
            pizarra.SetActive(true);
            if (contador == 1)
            {
                pregunta1.SetActive(true);
            }
            if (contador == 2)
            {
                pregunta2.SetActive(true);
            }
            if (contador == 3)
            {
                pregunta3.SetActive(true);
            }
            if (contador == 4)
            {
                pregunta4.SetActive(true);
            }
            if (contador == 5)
            {
                pregunta5.SetActive(true);
            }
        }else if (isPressed == false && contador == 5 && PointsController.instance.isDoor2 == false && PointsController.instance.isDoor3 == false)
        {
            Debug.Log("Entro1");
            PointsController.instance.isDoor2 = true;
            SceneManager.LoadScene("Lobby");
        }
        else if (isPressed == false && contador == 5 && PointsController.instance.isDoor2 == true)
        {
            Debug.Log("Entro2");
            PointsController.instance.isDoor2 = false;
            PointsController.instance.ChangeDoor3();
            SceneManager.LoadScene("Lobby");
        }else if (isPressed == false && contador == 5 && PointsController.instance.isDoor3 == true)
        {
            Debug.Log("Entro1");
            SceneManager.LoadScene("MensajeFinal");
        }
    }

    public void TirarBolos()
    {
        StartCoroutine(Esperar());
    }

    IEnumerator Esperar()
    {
        animacionBolos.SetBool("isStrike", true);
        yield return new WaitForSeconds(animacionBolos.GetCurrentAnimatorStateInfo(0).length);
        animacionBolos.SetBool("isStrike", false);
        contador++;
        BotonTirar.SetActive(false);
        isPressed = true;
    }

    public void Correcta()
    {
        bool correcta = true;
        StartCoroutine(Verificar(correcta));
    }

    public void Incorrecta()
    {
        bool incorreta = false;
        StartCoroutine(Verificar(incorreta));
    }



    IEnumerator Verificar(bool opcion)
    {
        if (opcion == true)
        {
            Correcto.SetActive(true);
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = Correct;
            audioSource.Play();
            yield return new WaitForSeconds(2);
            pizarra.SetActive(false);
            pregunta1.SetActive(false);
            pregunta2.SetActive(false);
            pregunta3.SetActive(false);
            pregunta4.SetActive(false);
            pregunta5.SetActive(false);
            Correcto.SetActive(false);
            BotonTirar.SetActive(true);
            isPressed = false;
            PointsController.instance.AddPoints(100);
        }
        else if (opcion == false)
        {
            Incorrecto.SetActive(true);
            AudioSource audioSource = GetComponent<AudioSource>();
            audioSource.clip = Incorrect;
            audioSource.Play();
            yield return new WaitForSeconds(2);
            pizarra.SetActive(false);
            pregunta1.SetActive(false);
            pregunta2.SetActive(false);
            pregunta3.SetActive(false);
            pregunta4.SetActive(false);
            pregunta5.SetActive(false);
            Incorrecto.SetActive(false);
            BotonTirar.SetActive(true);
            isPressed = false;
        }
    }
}
